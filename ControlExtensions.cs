using System.Reflection;


namespace scomp
{
    public static class ControlExtensions
    {
        public static void SetDoubleBuffered(this Control control, bool value)
        {
            // Get the type of the control
            Type controlType = control.GetType();

            // Get the PropertyInfo for the DoubleBuffered property
            PropertyInfo pi = controlType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);

            // Set the value of the DoubleBuffered property
            pi?.SetValue(control, value, null);
        }
    }
}
