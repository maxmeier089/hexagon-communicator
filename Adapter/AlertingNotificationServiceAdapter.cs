using Alerting;
using Communicator;

namespace Adapter
{
    public class AlertingNotificationServiceAdapter
    {

        private IAlertInputPort alertInput;

        private void Alerting_Alert(object? sender, AlertEventArgs e)
        {
            alertInput.Alert(e.Message);
        }

        public AlertingNotificationServiceAdapter(AlertingNotificationService alerting, IAlertInputPort alertInput)
        {
            this.alertInput = alertInput;
            alerting.Alert += Alerting_Alert;
        }

        
    }
}
