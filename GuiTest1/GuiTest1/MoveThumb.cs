using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace GuiTest1
{
    public class MoveThumb : Thumb
    {
        public MoveThumb()
        {
            DragDelta += new DragDeltaEventHandler(this.MoveThumb_DragDelta);
        }

        private void MoveThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            Control item = this.DataContext as Control;

            if (item != null)
            {
                double left = Canvas.GetLeft(item);
                if ((left + e.HorizontalChange) <= 0)
                {
                    Canvas.SetLeft(item, 0);
                }
                else
                {
                    Canvas.SetLeft(item, left + e.HorizontalChange);
                }
            }
        }
    }
}
