using System;

namespace Statistics
{
	public class EmailAlert : IAlerter
	{
		public bool emailSent;

		public EmailAlert()
        {
			this.emailSent = false;
        }

		public void alert()
        {
			this.emailSent = true;
        }

	}
}
