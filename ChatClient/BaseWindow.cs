using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ChatClient
{
    public class BaseWindow : Window
    {

        /// <summary>
        /// 处理窗体拖动事件,标题栏宽度为34
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && e.GetPosition((BaseWindow )sender).Y <= 34)
            {
                this.DragMove();
            }
        }

        /// <summary>
        /// 关闭当前窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 最小化当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnWindowMin_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(WindowStyle);
            if (WindowState == WindowState.Normal)
            {
                Topmost = false;
                if (WindowStyle != WindowStyle.SingleBorderWindow)
                {
                    //WindowStyle = WindowStyle.SingleBorderWindow;
                }
                //ResizeMode = ResizeMode.CanResizeWithGrip;
                //Left = (SystemParameters.WorkArea.Width - this.Width) / 2;
                //Top = (SystemParameters.WorkArea.Height - this.Height) / 2;
                WindowState = WindowState.Minimized;
            }
        }

        /// <summary>
        /// 窗体最大化最小化之后重设size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Window_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                ResizeMode = ResizeMode.NoResize;
            }
        }
    }
}
