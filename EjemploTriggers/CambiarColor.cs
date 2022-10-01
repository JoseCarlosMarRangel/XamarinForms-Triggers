using System;
using Xamarin.Forms;

namespace EjemploTriggers
{
    // ! Uso de clase abstracta triggeraction Button
    public class CambiarColor :TriggerAction<Button>
    {
        // ! Metodo que cambia el color y cambia el valor de hola mundo
        protected override void Invoke(Button sender)
        {
            sender.BackgroundColor = Color.DarkOrange;
            sender.Text = "Hola hola mundo";
        }
    }
}
