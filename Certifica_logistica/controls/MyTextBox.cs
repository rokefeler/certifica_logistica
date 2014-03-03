using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Certifica_logistica.controls
{
    /// <summary>
    /// Un textBox que no admite carcateres especiales como ´'|
    /// </summary>
    public class MyTextBox : TextBox
    {
        public enum Vista
        {
            Normal,
            Error
        }
        private Vista _myVista;
        /// <summary>
        /// Determina el tipo de dato permitido en el pca
        /// </summary>
        public enum Tipo
        {
            /// <summary>
            /// Permitir Caracteres Especiales
            /// </summary>
            StringEspeciales,

            /// <summary>
            /// No Permitit Caracteres Especiales
            /// </summary>
            StringNoEspeciales,

            /// <summary>
            /// Permitir solo Numeros Enteros
            /// </summary>
            Enteros,

            /// <summary>
            /// Permite solo Numeros Enteros Positivos
            /// </summary>
            EnterosPositivos,

            /// <summary>
            /// Permitir solo Numeros Decimales
            /// </summary>
            Decimales
        }

        [Description("Determina el tipo de dato que se puede introducir en el Texbox")]
        [Category("Datos")]
        [DefaultValue(Tipo.StringEspeciales)]
        public Tipo TipoDato { get; set; }

        readonly char[] _digitosEnteros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', '\b' };

        readonly char[] _digitosEnterosPositivos = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '\b' };

        readonly char[] _digitosDecimales = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', ',', '-', '\b' };

        readonly char[] _digitosEspeciales = { (char)(34), (char)(35), (char)(36), (char)(39), (char)(43) };

        protected virtual bool CaracterCorrecto(Char c)
        {
            switch (TipoDato)
            {
                case Tipo.Decimales:
                    return !(Array.IndexOf(_digitosDecimales, c) == -1);
                case Tipo.Enteros:
                    return !(Array.IndexOf(_digitosEnteros, c) == -1);
                case Tipo.EnterosPositivos:
                    return !(Array.IndexOf(_digitosEnterosPositivos, c) == -1);
                case Tipo.StringEspeciales:
                    return true;
                case Tipo.StringNoEspeciales:
                    return (Array.IndexOf(_digitosEspeciales, c) == -1);
                default:
                    return false;
            }
        }

        #region Propiedades de apariencia

        public Vista Apariencia
        {
            get
            {
                return _myVista;
            }
            set
            {
                _myVista = value;
                CambiarVista();
            }
        }

        private void CambiarVista()
        {
            switch (_myVista)
            {
                case Vista.Error:
                    BackColor = Color.FromArgb(255, 128, 128);
                    ForeColor = Color.FromName("Window");
                    break;
                case Vista.Normal:
                    BackColor = Color.FromName("Window");
                    ForeColor = Color.FromName("WindowText");
                    break;
            }
        }


        #endregion

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!CaracterCorrecto(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        /*
        protected override void OnTextChanged(EventArgs e)
        {
            this.Apariencia = Vista.Normal;   
            base.OnTextChanged(e);
        }
        */

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                var s = "";
                foreach (char c in value)
                {
                    if (CaracterCorrecto(c))
                        s += c;
                }
                base.Text = s;
            }
        }
    }
}
