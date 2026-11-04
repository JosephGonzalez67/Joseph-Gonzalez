using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joseph_Gonzalez
{
    public partial class MembershipForm : Form
    {
        // Constantes de precios de membresía (naming convention: UPPER_SNAKE o Pascal para const)
        private const decimal STANDARD_ADULT_RATE = 40.00m;
        private const decimal CHILD_RATE = 20.00m;
        private const decimal STUDENT_RATE = 25.00m;
        private const decimal SENIOR_RATE = 30.00m;

        // Constantes de opciones adicionales
        private const decimal KARATE_FEE = 10.00m;
        private const decimal YOGA_FEE = 30.00m;
        private const decimal PERSONAL_TRAINER_FEE = 50.00m;

        // Límites de meses según política del club
        private const int MIN_MONTHS = 1;
        private const int MAX_MONTHS = 24;
        public MembershipForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void karateCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            lblFirstName.Clear();
            txtLastName.Clear();
            numberMoths.Clear();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Limpiar resultados previos
            monthlyFeeL.Text = "";
            totalLabel.Text = "";

            if (!standardadultRadioButton.Checked && !childRadioButton.Checked &&
                !studentRadioButton.Checked && !seniorcitizenRadioButton.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de membresía.",
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                membershipGroupBox.Focus();
                return;
            }

            int numberOfMonths;
            if (string.IsNullOrWhiteSpace(numberMoths.Text))
            {
                MessageBox.Show("Debe ingresar el número de meses de la membresía.",
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberMoths.Focus();
                return;
            }

            // Usar TryParse para evitar excepciones de conversión
            if (!int.TryParse(numberMoths.Text, out numberOfMonths))
            {
                MessageBox.Show("El número de meses debe ser un valor numérico entero.",
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberMoths.Focus();
                numberMoths.SelectAll();
                return;
            }

            if (numberOfMonths < MIN_MONTHS || numberOfMonths > MAX_MONTHS)
            {
                MessageBox.Show($"El número de meses debe estar entre {MIN_MONTHS} y {MAX_MONTHS}.\n" +
                                "No se permiten fracciones de mes ni paquetes mayores a 24 meses.",
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberMoths.Focus();
                numberMoths.SelectAll();
                return;
            }

            // ========== CÁLCULO (solo si toda la entrada es válida) ==========

            // Determinar tarifa base según el radio button seleccionado
            decimal monthlyBaseRate = 0m;

            if (standardadultRadioButton.Checked)
            {
                monthlyBaseRate = STANDARD_ADULT_RATE;
            }
            else if (childRadioButton.Checked)
            {
                monthlyBaseRate = CHILD_RATE;
            }
            else if (studentRadioButton.Checked)
            {
                monthlyBaseRate = STUDENT_RATE;
            }
            else if (seniorcitizenRadioButton.Checked)
            {
                monthlyBaseRate = SENIOR_RATE;
            }

            // Sumar opciones adicionales (checkboxes)
            decimal optionsTotal = 0m;

            if (karateCheckBox.Checked)
            {
                optionsTotal += KARATE_FEE;
            }
            if (yogaCheckBox.Checked)
            {
                optionsTotal += YOGA_FEE;
            }
            if (personaltrainerCheckBox.Checked)
            {
                optionsTotal += PERSONAL_TRAINER_FEE;
            }

            // Calcular cuotas
            decimal monthlyFee = monthlyBaseRate + optionsTotal;
            decimal totalFee = monthlyFee * numberOfMonths;

            // Mostrar resultados con formato de moneda
            monthlyFeeL.Text = monthlyFee.ToString("C");
            totalL.Text = totalFee.ToString("C");

            // Mensaje de confirmación opcional
            string clientName = nombre.Text.Trim() + " " + txtLastName.Text.Trim();
            MessageBox.Show($"Cálculo completado para: {clientName}\n\n" +
                            $"Cuota Mensual: {monthlyFee:C}\n" +
                            $"Total por {numberOfMonths} mes(es): {totalFee:C}",
                "Cálculo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Evento del botón Clear.
        /// Limpia campos, desmarca opciones y devuelve el foco al primer TextBox.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Limpiar TextBoxes
            lblFirstName.Clear();
            txtLastName.Clear();
            numberMoths.Clear();

            // Limpiar labels de resultados
            monthlyFeeL.Text = "";
            totalL.Text = "";

            // Desmarcar radio buttons
            standardadultRadioButton.Checked = false;
            childRadioButton .Checked = false;
            studentRadioButton .Checked = false;
            seniorcitizenRadioButton .Checked = false;

            // Desmarcar checkboxes
            karateCheckBox .Checked = false;
            yogaCheckBox .Checked = false;
            personaltrainerCheckBox .Checked = false;

            // Devolver el foco al primer campo (nombre del cliente)
            nombre.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento del botón Exit.
        /// Cierra el formulario.
        /// </summary>

    }
}

