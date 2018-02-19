using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Jakob
{
	/// <summary>
	/// Class sends the message via SMTP or VMessage
	/// </summary>
	class MessageSender
	{
		TextToHTMLConverter textToHTML;
		public enum MessageCarrier { Smtp, VMessage }

		// Metode kan fjernes da SendMessageToAll gjorde de samme
		//public void SendMessage(MessageCarrier type, Message m, bool isHTML)
		//{
		//	//herinde sendes der en email ud til modtageren
		//	if (type.Equals(MessageCarrier.Smtp))
		//	{
		//		if (isHTML)
		//			m.Body = ConvertBodyToHTML(m.Body);
		//		//her implementeres alt koden til at sende via Smtp
		//	}

		//	if (type.Equals(MessageCarrier.VMessage))
		//	{
		//		if (isHTML)
		//			m.Body = ConvertBodyToHTML(m.Body);
		//		//her implementeres alt koden til at sende via VMessage
		//	}
		//} // Gør det samme som SendMessageToAll

		// Converter til HTML
		

		// Sender til alle
		/// <summary>
		/// Sends the message via the specified MessageCarrier type.
		/// </summary>
		/// <param name="type">SMTP / VMessage</param>
		/// <param name="to"></param>
		/// <param name="m"></param>
		/// <param name="isHTML"></param>
		public void SendMessage(MessageCarrier type, string[] to, Message m, bool isHTML)
		{
			if (type.Equals(MessageCarrier.Smtp))
			{
				if (isHTML)
					m.Body = textToHTML.ConvertBodyToHTML(m.Body);
				// Her sendes beskeden via SMTP
				SMTPSender smtp = new SMTPSender();
				smtp.Send(m.Body);
			}

			if (type.Equals(MessageCarrier.VMessage))
			{
				if (isHTML)
					m.Body = textToHTML.ConvertBodyToHTML(m.Body);
				// Her sendes beskeden vi VMessage
				VMessageSender vm = new VMessageSender();
				vm.Send(m.Body);
			}
		}
	}
}
