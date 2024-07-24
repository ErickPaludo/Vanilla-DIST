using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class LoginClass
    {
        public bool Login(string user, string pass)
        {
            Util util;
            Database db = new Database();
            Config config = new Config();
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_users.vnl_login_user", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_user", OracleDbType.Varchar2).Value = user;
                        cmd.Parameters.Add("v_pass", OracleDbType.Varchar2).Value = pass;

                        string vpnIpAddress = GetVpnIpAddress();
                        if (vpnIpAddress != null) //coleta ip da vpn
                        {
                            cmd.Parameters.Add("v_ip", OracleDbType.Varchar2).Value = vpnIpAddress;
                        }
                        else //Coleta ip da rede
                        {
                            cmd.Parameters.Add("v_ip", OracleDbType.Varchar2).Value = Dns.GetHostAddresses(Dns.GetHostName())
                      .FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

                        }

                        cmd.Parameters.Add("v_host", OracleDbType.Varchar2).Value = System.Net.Dns.GetHostName();
                        cmd.Parameters.Add("r_verificador", OracleDbType.Boolean).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("r_msg", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("r_id_user", OracleDbType.Int32).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("r_perm", OracleDbType.Int32).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        string msg = cmd.Parameters["r_msg"].Value.ToString();
                        decimal id = ((OracleDecimal)cmd.Parameters["r_id_user"].Value).Value;
                        bool ver = ((OracleBoolean)cmd.Parameters["r_verificador"].Value).IsTrue;
                        decimal perm = ((OracleDecimal)cmd.Parameters["r_perm"].Value).Value;
                        string name = user;
                        util = new Util();
                        util.DadosUser(Convert.ToInt32(id), Convert.ToInt32(perm), name);
                        if (ver == false)
                        {
                            MessageBox.Show(msg);
                        }
                        else
                        {
                            db.AddLog("USUÁRIO LOGADO!", Util.id_user); //temporário
                        }
                        return ver;
                    }
                }
                catch (Exception ex)
                {
                    ErrorBox errorBox = new ErrorBox("Favor Verificar a conexao com o banco de dados!",ex.Message);
                    return false;
                }
            }

        }
        public static string GetVpnIpAddress()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up && ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && ip.IPv4Mask != null)
                        {
                            // Assuming VPN IPs might be differentiated in some way, otherwise add more specific checks
                            return ip.Address.ToString();
                        }
                    }
                }
            }
            return null;
        }
    }
}
