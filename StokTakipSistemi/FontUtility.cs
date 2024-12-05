﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;          // Font işlemleri için gerekli
using System.Drawing.Text;     // Özel font yükleme işlemleri için gerekli
using System.IO;               // Dosya işlemleri için gerekli
using System.Windows.Forms;


namespace StokTakipSistemi
{
    internal class FontUtility
    {
        // Tüm kontrol ve alt kontrollerin fontunu uygulamak için method
        public static void ApplyCustomFontToAllControls(Control parent, string fontFamilyName, float fontSize)
        {
            // Fontu PrivateFontCollection ile yükle
            Font customFont = new Font(fontFamilyName, fontSize, FontStyle.Regular);  // Sadece düz font

            // Tüm kontrolleri gez ve fontu uygula
            ApplyFontToControls(parent, customFont);
        }

        // Kontrollerin fontlarını uygular
        private static void ApplyFontToControls(Control parent, Font font)
        {
            foreach (Control c in parent.Controls)
            {
                // Eğer kontrol bir Button ise
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat; // Düz buton stili
                    btn.FlatAppearance.BorderSize = 0; // Kenarlık yok
                    btn.Font = font; // Fontu uygula
                    btn.BackColor = ColorTranslator.FromHtml("#F8F8FA"); // Butonun arka plan rengini ayarla
                }
                // Eğer kontrol bir Label ise
                else if (c is Label lbl)
                {
                    lbl.Font = font; // Fontu uygula
                }
                // Eğer kontrol bir TextBox veya MaskedTextBox ise
                else if (c is TextBox txt)
                {
                    txt.Font = font; // Fontu uygula
                }
                else if (c is MaskedTextBox maskedTxt)
                {
                    maskedTxt.Font = font; // Fontu uygula
                }
                // Eğer kontrol bir ComboBox ise
                else if (c is ComboBox combo)
                {
                    combo.Font = font; // Fontu uygula
                }
                // Eğer kontrol bir ListBox ise
                else if (c is ListBox list)
                {
                    list.Font = font; // Fontu uygula
                }
                // Eğer kontrol bir RadioButton ise
                else if (c is RadioButton radio)
                {
                    radio.Font = font; // Fontu uygula
                }
                // Eğer kontrol bir CheckBox ise
                else if (c is CheckBox check)
                {
                    check.Font = font; // Fontu uygula
                }

                // Eğer kontrolün alt kontrolleri varsa, o kontrollerin fontlarını da uygula
                if (c.Controls.Count > 0)
                {
                    ApplyFontToControls(c, font);
                }
            }
        }

    }
}
