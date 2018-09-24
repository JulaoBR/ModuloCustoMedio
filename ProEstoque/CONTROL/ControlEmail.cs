using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProEstoque.CONTROL
{
    public class ControlEmail
    {
        private static string emailOrigem = "julioscp1021@gmail.com";
        private static string emailDestino = "julio@massaslott.com.br, eliana@massaslott.com.br, vandreialot@massaslott.com.br";

        public ControlEmail()
        {

        }

        public static void EnviaEmailEstoqueMinimo(ModelRegistro registro)
        {
            //CLIENTE
            SmtpClient cliente = new SmtpClient();
            NetworkCredential credencial = new NetworkCredential();

            //DEFINIR CONFIGURAÇÔES CLIENTE
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;

            //DEFINIR AS CREDENCIAIS DE ACESSO AO EMAIL
            credencial.UserName = "julioscp1021";
            credencial.Password = "jcs1021120915";

            //DEFINE AS CREDENCIAIS NO CLIENTE
            cliente.Credentials = credencial;

            //PREPAPAR A  +MENSAGEM A ENVIAR
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(emailOrigem);
            mensagem.Subject = "ALERTA DE PRODUTO ABAIXO DO ESTOQUE MINIMO";
            //FORMATACAO HTML
            mensagem.IsBodyHtml = true;

            StringBuilder body = new StringBuilder();

            body.Append("<html>");
            body.Append("<body style=\"font-family:Arial, Helvetica, sans-serif; font-size: 14px\">");
            body.Append("<img src=\"cid:logo\" title=\"logo\" />");
            body.Append("<h2>Produto entrou na zona de estoque minimo!</h2>");
            body.Append("Vandréia Mara Lot<br>");
            body.Append("CNPJ: 06.049.863/0001-30 - IE: 611.004.132-114<br>");
            body.Append("Av. Ricardo Aparecido Bellomi, 665 - S.C.Palmeiras/SP<br>");
            body.Append("Fone: 19 3672 1502<br>");
            body.Append("<hr/>");
            body.Append("<p>O produto " + registro.descricao + " entrou na zona de estoque minimo.<br>Favor entrar em contato com fornecedor para reposição.</p> <br><br>");

            body.Append("<table>");
            body.Append("<thead>");
            body.Append("<tr>");
            body.Append("<th>PRODUTO</th>");
            body.Append("<th>ESTOQUE MINIMO</th>");
            body.Append("<th>ESTOQUE ATUAL</th>");
            body.Append("</tr>");
            body.Append("<tbody>");
            body.Append("<tr>");
            body.Append("<td style=\"font-family:Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; background-color: #cedeeb; border: 1px solid #000080;vertical-align: top; text-align: center;\">" +registro.descricao+ "</td>");
            body.Append("<td style=\"font-family:Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; background-color: #cedeeb; border: 1px solid #000080;vertical-align: top; text-align: center;\">"+ registro.estoque_minimo +"</td>");
            body.Append("<td style=\"font-family:Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; background-color: #cedeeb; border: 1px solid #000080;vertical-align: top; text-align: center;\">"+ registro.saldo +"</td>");
            body.Append("</tr>");
            body.Append("</tbody>");
            body.Append("</table>");

            body.Append("<br><br>");
            body.Append("<hr/>");
            body.Append("<p>Email enviado automaticamente pelo sistema - " + DateTime.Now + "</p>");

            body.Append("</body>");
            body.Append("</html>");

            AlternateView av = AlternateView.CreateAlternateViewFromString(body.ToString(), new ContentType("text/html"));

            mensagem.AlternateViews.Add(av);
            mensagem.To.Add(emailDestino);

            try
            {
                //ENVIO DA MENSAGEM DE EMAIL
                cliente.Send(mensagem);
                MessageBox.Show("Email de notificação de baixa de estoque enviado com sucesso!");
                return;
            }
            catch
            {
                MessageBox.Show("Não foi possivel enviar o email de notificação de baixa de estoque!");
                return;
            }

        }

        public static void EnviaEmailEstoqueSeguranca(ModelRegistro registro)
        {
            //CLIENTE
            SmtpClient cliente = new SmtpClient();
            NetworkCredential credencial = new NetworkCredential();

            //DEFINIR CONFIGURAÇÔES CLIENTE
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;

            //DEFINIR AS CREDENCIAIS DE ACESSO AO EMAIL
            credencial.UserName = "julioscp1021";
            credencial.Password = "jcs1021120915";

            //DEFINE AS CREDENCIAIS NO CLIENTE
            cliente.Credentials = credencial;

            //PREPAPAR A  +MENSAGEM A ENVIAR
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(emailOrigem);
            mensagem.Subject = "ALERTA DE PRODUTO EM ESTOQUE DE SEGURANÇA";
            //FORMATACAO HTML
            mensagem.IsBodyHtml = true;

            StringBuilder body = new StringBuilder();

            body.Append("<html>");
            body.Append("<body style=\"font-family:Arial, Helvetica, sans-serif; font-size: 14px\">");
            body.Append("<img src=\"cid:logo\" title=\"logo\" />");
            body.Append("<h2>Produto entrou na zona de segurança!</h2>");
            body.Append("Vandréia Mara Lot<br>");
            body.Append("CNPJ: 06.049.863/0001-30 - IE: 611.004.132-114<br>");
            body.Append("Av. Ricardo Aparecido Bellomi, 665 - S.C.Palmeiras/SP<br>");
            body.Append("Fone: 19 3672 1502<br>");
            body.Append("<hr/>");
            body.Append("<p>O produto " + registro.descricao + " entrou na zona de estoque de segurança.<br>Favor entrar em contato com fornecedor para fazer cotação.</p> <br><br>");

            body.Append("<table>");
            body.Append("<thead>");
            body.Append("<tr>");
            body.Append("<th>PRODUTO</th>");
            body.Append("<th>ESTOQUE SEGURANÇA</th>");
            body.Append("<th>ESTOQUE ATUAL</th>");
            body.Append("</tr>");
            body.Append("<tbody>");
            body.Append("<tr>");
            body.Append("<td style=\"font-family:Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; background-color: #cedeeb; border: 1px solid #000080;vertical-align: top; text-align: center;\">" + registro.descricao + "</td>");
            body.Append("<td style=\"font-family:Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; background-color: #cedeeb; border: 1px solid #000080;vertical-align: top; text-align: center;\">" + registro.estoque_seguranca + "</td>");
            body.Append("<td style=\"font-family:Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; background-color: #cedeeb; border: 1px solid #000080;vertical-align: top; text-align: center;\">" + registro.saldo + "</td>");
            body.Append("</tr>");
            body.Append("</tbody>");
            body.Append("</table>");

            body.Append("<br><br>");
            body.Append("<hr/>");
            body.Append("<p>Email enviado automaticamente pelo sistema - " + DateTime.Now + "</p>");

            body.Append("</body>");
            body.Append("</html>");

            AlternateView av = AlternateView.CreateAlternateViewFromString(body.ToString(), new ContentType("text/html"));

            mensagem.AlternateViews.Add(av);
            mensagem.To.Add(emailDestino);

            try
            {
                //ENVIO DA MENSAGEM DE EMAIL
                cliente.Send(mensagem);
                MessageBox.Show("Email de notificação de estoque de segurança enviado com sucesso!");
                return;
            }
            catch
            {
                MessageBox.Show("Não foi possivel enviar o email de notificação de estoque de segurança!");
                return;
            }

        }
    }
}
