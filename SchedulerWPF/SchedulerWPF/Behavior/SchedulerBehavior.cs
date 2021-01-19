using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;
using System.Windows;

namespace WpfScheduler
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {
        SfScheduler scheduler;
        protected override void OnAttached()
        {
            base.OnAttached();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("AR");
            scheduler = this.AssociatedObject;
            this.AssociatedObject.FlowDirection = FlowDirection.RightToLeft;
        }
    }
}

