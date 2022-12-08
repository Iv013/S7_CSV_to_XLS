using CSV_TXT_to_XLS.Properties;
using System;
using System.Drawing;
using System.Threading.Tasks;



namespace CSV_TXT_to_XLS
{
    public static  class ExtansionAnimationForm
    {
       public static async void ResizeHeight(this System.Windows.Forms.Form form, int minHeight=273, int maxHeight = 450)
        {
            bool move = false;
            int delta;
            if (form.Height < minHeight+13)
            {
                while ((form.Height <= maxHeight) & (!move))
                {
                    move = true;
                    delta = Convert.ToInt32(Math.Ceiling(Convert.ToDouble((maxHeight - form.Height) / 8)));
                    await Task.Delay(1);
                    form.Size = new Size(form.Width, form.Height + delta + 1);
                    move = false;
                }   
            }

            else if (form.Height >= maxHeight-10)
            {
                while ((form.Height >= minHeight) & (!move))
                {
                    move = true;
                    delta = Convert.ToInt32(Math.Ceiling(Convert.ToDouble((form.Height - minHeight) / 8)));
                    await Task.Delay(1);
                    form.Size = new Size(form.Width, form.Height - delta - 1);
                    move = false;
                }

            }

        }
    }
}
