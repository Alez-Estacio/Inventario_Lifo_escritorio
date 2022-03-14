using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace lifo2
{
    public partial class Form1 : Form
    {
        
         private double cantidadsalida = 0, costosalida = 0, cant = 0, costunidad = 0, totalimpresora = 0, totalgabinete = 0, totalmonitor = 0, totalprocesadores = 0, totalram = 0, totaldisipador = 0,  cantidevoculion = 0, costodevolucion =0;
        string FECHA = ("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void pp()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {






            // calcular filas
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(grid);

            
            cant = double.Parse(txcantidad.Text);
            costunidad = double.Parse(txcostou.Text);
            cantidadsalida = Convert.ToInt32(txcantidads.Text);
            costosalida = double.Parse(txcostos.Text);



                       
                        
                           
                            



                                if (cbinventario.Text == "procesador")
                                {
                                    totalprocesadores = totalprocesadores - cantidadsalida;

                                    file.Cells[0].Value = (FECHA);
                                    file.Cells[1].Value = (cbinventario.Text);
                                    file.Cells[2].Value = cant;
                                    file.Cells[3].Value = costunidad;
                                    file.Cells[4].Value = (float.Parse(txcantidad.Text) * float.Parse(txcostou.Text));
                                    file.Cells[5].Value = cantidadsalida;
                                    file.Cells[6].Value = costosalida;
                                    file.Cells[7].Value = cantidadsalida * costosalida;
                                    file.Cells[11].Value = totalprocesadores - cantidadsalida;
                                    file.Cells[12].Value = costosalida;
                                    file.Cells[13].Value = totalprocesadores * costosalida;

                                }
                                else
                                {
                                    if (cbinventario.Text == "impresora")
                                    {
                                        totalimpresora = totalimpresora - cantidadsalida;



                                        file.Cells[0].Value = (FECHA);
                                        file.Cells[1].Value = (cbinventario.Text);
                                        file.Cells[2].Value = cant;
                                        file.Cells[3].Value = costunidad;
                                        file.Cells[4].Value = cant * costunidad;
                                        file.Cells[5].Value = cantidadsalida;
                                        file.Cells[6].Value = costosalida;
                                        file.Cells[7].Value = cantidadsalida * costosalida;
                                        file.Cells[11].Value = totalimpresora;
                                        file.Cells[12].Value = costosalida;
                                        file.Cells[13].Value = totalimpresora * costosalida;
                                    }
                                    else
                                    {
                                        if (cbinventario.Text == "ram")
                                        {
                                            totalram = totalram - cantidadsalida;

                                            file.Cells[0].Value = (FECHA);
                                            file.Cells[1].Value = (cbinventario.Text);
                                            file.Cells[2].Value = cant;
                                            file.Cells[3].Value = costunidad;
                                            file.Cells[4].Value = (float.Parse(txcantidad.Text) * float.Parse(txcostou.Text));
                                            file.Cells[5].Value = cantidadsalida;
                                            file.Cells[6].Value = costosalida;
                                            file.Cells[7].Value = cantidadsalida * costosalida;
                                            file.Cells[11].Value = totalram;
                                            file.Cells[12].Value = costosalida;
                                            file.Cells[13].Value = totalram * costosalida;
                                        }


                                        else
                                        {
                                            if (cbinventario.Text == "gabinete")
                                            {
                                                totalgabinete = totalgabinete - cantidadsalida;
                                                file.Cells[0].Value = (FECHA);
                                                file.Cells[1].Value = (cbinventario.Text);
                                                file.Cells[2].Value = cant;
                                                file.Cells[3].Value = costunidad;
                                                file.Cells[4].Value = (float.Parse(txcantidad.Text) * float.Parse(txcostou.Text));
                                                file.Cells[5].Value = cantidadsalida;
                                                file.Cells[6].Value = costosalida;
                                                file.Cells[7].Value = cantidadsalida * costosalida;
                                                file.Cells[11].Value = totalgabinete;
                                                file.Cells[12].Value = costosalida;
                                                file.Cells[13].Value = totalgabinete * costosalida;

                                            }
                                            else
                                            {
                                                if (cbinventario.Text == "monitor")
                                                {
                                                    totalmonitor = totalmonitor - cantidadsalida;
                                                    file.Cells[0].Value = (FECHA);
                                                    file.Cells[1].Value = (cbinventario.Text);
                                                    file.Cells[2].Value = cant;
                                                    file.Cells[3].Value = costunidad;
                                                    file.Cells[4].Value = (float.Parse(txcantidad.Text) * float.Parse(txcostou.Text));
                                                    file.Cells[5].Value = cantidadsalida;
                                                    file.Cells[6].Value = costosalida;
                                                    file.Cells[7].Value = cantidadsalida * costosalida;
                                                    file.Cells[11].Value = totalmonitor;
                                                    file.Cells[12].Value = costosalida;
                                                    file.Cells[13].Value = totalmonitor * costosalida;

                                                }
                                                else
                                                {
                                                    if (cbinventario.Text == "disipador")
                                                    {
                                                        totaldisipador = totaldisipador - cantidadsalida;
                                                        file.Cells[0].Value = (FECHA);
                                                        file.Cells[1].Value = (cbinventario.Text);
                                                        file.Cells[2].Value = cant;
                                                        file.Cells[3].Value = costunidad;
                                                        file.Cells[4].Value = (float.Parse(txcantidad.Text) * float.Parse(txcostou.Text));
                                                        file.Cells[5].Value = cantidadsalida;
                                                        file.Cells[6].Value = costosalida;
                                                        file.Cells[7].Value = cantidadsalida * costosalida;
                                                        file.Cells[11].Value = totaldisipador;
                                                        file.Cells[12].Value = costosalida;
                                                        file.Cells[13].Value = totaldisipador * costosalida;

                                                    }

                                                   
                                                }
                                            }
                                        }
                                    }
                                }
                            

                        





            



            grid.Rows.Add(file);

            //calculo de columnas 
            double total = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {

                total += Convert.ToDouble(row.Cells["column3"].Value);

            }

             txttotal.Text = Convert.ToString(total);

            double totalex = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {

                totalex += Convert.ToDouble(row.Cells["column10"].Value);

            }

            txtotalexis.Text = Convert.ToString(totalex);

            double totalsl = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {

                totalsl += Convert.ToDouble(row.Cells["column7"].Value);

            }

            txtotalsalida.Text = Convert.ToString(totalsl);


            //borrar espacios 
            txcantidad.Text = txcostou.Text = txcostos.Text = txcantidads.Text = "0";
            cbinventario.Text = "";




        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void txfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            grid.Rows.Clear();
            txtotalexis.Text = txttotal.Text = "0";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // calcular filas
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(grid);

            
            cant = double.Parse(txcantidad.Text);
            costunidad = double.Parse(txcostou.Text);
            cantidadsalida = Convert.ToInt32(txcantidads.Text);
            costosalida = double.Parse(txcostos.Text);

            if (cbinventario.Text == "procesador")
            {

                totalprocesadores = totalprocesadores + cant;

                file.Cells[0].Value = (FECHA);
                file.Cells[1].Value = (cbinventario.Text);
                file.Cells[2].Value = cant;
                file.Cells[3].Value = costunidad;
                file.Cells[4].Value = cant * costunidad;
                file.Cells[5].Value = cantidadsalida;
                file.Cells[6].Value = costosalida;
                file.Cells[7].Value = cantidadsalida * costosalida;
                file.Cells[11].Value = totalprocesadores;
                file.Cells[12].Value = file.Cells[3].Value.ToString();
                file.Cells[13].Value = totalprocesadores * costunidad;

            }
            else
            {
                if (cbinventario.Text == "impresora")
                {
                    totalimpresora = (totalimpresora) + cant;



                    file.Cells[0].Value = (FECHA);
                    file.Cells[1].Value = (cbinventario.Text);
                    file.Cells[2].Value = cant;
                    file.Cells[3].Value = costunidad;
                    file.Cells[4].Value = cant * costunidad;
                    file.Cells[5].Value = cantidadsalida;
                    file.Cells[6].Value = costosalida;
                    file.Cells[7].Value = cantidadsalida * costosalida;
                    file.Cells[11].Value = totalimpresora;
                    file.Cells[12].Value = costunidad;
                    file.Cells[13].Value = totalimpresora * costunidad;

                }


                else
                {
                    if (cbinventario.Text == "ram")
                    {
                        totalram += totalram + cant;

                        file.Cells[0].Value = (FECHA);
                        file.Cells[1].Value = (cbinventario.Text);
                        file.Cells[2].Value = cant;
                        file.Cells[3].Value = costunidad;
                        file.Cells[4].Value = (float.Parse(txcantidad.Text) * float.Parse(txcostou.Text));
                        file.Cells[5].Value = cantidadsalida;
                        file.Cells[6].Value = costosalida;
                        file.Cells[7].Value = cantidadsalida * costosalida;
                        file.Cells[11].Value = totalram;
                        file.Cells[12].Value = file.Cells[3].Value.ToString();
                        file.Cells[13].Value = totalram * costunidad;
                    }


                    else
                    {
                        if (cbinventario.Text == "gabinete")
                        {

                            totalgabinete = totalgabinete + cant;
                            file.Cells[0].Value = (FECHA);
                            file.Cells[1].Value = (cbinventario.Text);
                            file.Cells[2].Value = cant;
                            file.Cells[3].Value = costunidad;
                            file.Cells[4].Value = (float.Parse(txcantidad.Text) * float.Parse(txcostou.Text));
                            file.Cells[5].Value = cantidadsalida;
                            file.Cells[6].Value = costosalida;
                            file.Cells[7].Value = cantidadsalida * costosalida;
                            file.Cells[11].Value = totalgabinete;
                            file.Cells[12].Value = file.Cells[3].Value.ToString();
                            file.Cells[13].Value = totalgabinete * costunidad;

                        }
                        else
                        {
                            if (cbinventario.Text == "monitor")
                            {
                                totalmonitor += totalmonitor + cant;
                                file.Cells[0].Value = (FECHA);
                                file.Cells[1].Value = (cbinventario.Text);
                                file.Cells[2].Value = cant;
                                file.Cells[3].Value = costunidad;
                                file.Cells[4].Value = (float.Parse(txcantidad.Text) * float.Parse(txcostou.Text));
                                file.Cells[5].Value = cantidadsalida;
                                file.Cells[6].Value = costosalida;
                                file.Cells[7].Value = cantidadsalida * costosalida;
                                file.Cells[11].Value = totalmonitor;
                                file.Cells[12].Value = file.Cells[3].Value.ToString();
                                file.Cells[13].Value = totalmonitor * costunidad;

                            }
                            else
                            {
                                if (cbinventario.Text == "disipador")
                                {
                                    totaldisipador += totaldisipador + cant;
                                    file.Cells[0].Value = (FECHA);
                                    file.Cells[1].Value = (cbinventario.Text);
                                    file.Cells[2].Value = cant;
                                    file.Cells[3].Value = costunidad;
                                    file.Cells[4].Value = (float.Parse(txcantidad.Text) * float.Parse(txcostou.Text));
                                    file.Cells[5].Value = cantidadsalida;
                                    file.Cells[6].Value = costosalida;
                                    file.Cells[7].Value = cantidadsalida * costosalida;
                                    file.Cells[11].Value = totaldisipador;
                                    file.Cells[12].Value = file.Cells[3].Value.ToString();
                                    file.Cells[13].Value = totaldisipador * costunidad;

                                }
                            }
                        }
                    }
                }
            }


            grid.Rows.Add(file);

            //calculo de columnas 
            double total = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {

                total += Convert.ToDouble(row.Cells["column3"].Value);

            }

            txttotal.Text = Convert.ToString(total);

            double totalex = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {

                totalex += Convert.ToDouble(row.Cells["column10"].Value);

            }

            txtotalexis.Text = Convert.ToString(totalex);

            double totalsl = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {

                totalsl += Convert.ToDouble(row.Cells["column7"].Value);

            }

            txtotalsalida.Text = Convert.ToString(totalsl);


            //borrar espacios 
            txcantidad.Text = txcostou.Text =   txcostos.Text = txcantidads.Text = "0";
            cbinventario.Text = "";
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btdevol_Click(object sender, EventArgs e)

        {
            
            // calcular filas
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(grid);

           string FECHA = ("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            //cambiar nombre de variable  y declararla en el metodo

            cantidevoculion = Convert.ToInt32(txcandevol.Text);
            costodevolucion = double.Parse(txcostdevo.Text);










            if (cbinventario.Text == "procesador")
            {
                totalprocesadores = totalprocesadores - cantidevoculion;

                file.Cells[0].Value = (FECHA);
                file.Cells[1].Value = (cbinventario.Text);
                file.Cells[8].Value = cantidevoculion;
                file.Cells[9].Value = costodevolucion;
                file.Cells[10].Value = cantidevoculion * costodevolucion;
                file.Cells[11].Value = totalprocesadores ;
                file.Cells[12].Value = costodevolucion ;
                file.Cells[13].Value = totalprocesadores * costodevolucion;

            }
            else
            {
                if (cbinventario.Text == "impresora")
                {
                    totalimpresora = totalimpresora - cantidevoculion;

                    file.Cells[0].Value = (FECHA);
                    file.Cells[1].Value = (cbinventario.Text);
                    file.Cells[8].Value = cantidevoculion;
                    file.Cells[9].Value = costodevolucion;
                    file.Cells[10].Value = cantidevoculion * costodevolucion;
                    file.Cells[11].Value = totalimpresora;
                    file.Cells[12].Value = costodevolucion;
                    file.Cells[13].Value = totalimpresora * costodevolucion;




                }
                else
                {
                    if (cbinventario.Text == "ram")
                    {
                        totalram = totalram - cantidevoculion;
                        file.Cells[0].Value = (FECHA);
                        file.Cells[1].Value = (cbinventario.Text);
                        file.Cells[8].Value = cantidevoculion;
                        file.Cells[9].Value = costodevolucion;
                        file.Cells[10].Value = cantidevoculion * costodevolucion;
                        file.Cells[11].Value = totalram;
                        file.Cells[12].Value = costodevolucion;
                        file.Cells[13].Value = totalram * costodevolucion;


                    }


                    else
                    {
                        if (cbinventario.Text == "gabinete")
                        {
                            totalgabinete = totalgabinete - cantidevoculion;
                            file.Cells[0].Value = (FECHA);
                            file.Cells[1].Value = (cbinventario.Text);
                            file.Cells[8].Value = cantidevoculion;
                            file.Cells[9].Value = costodevolucion;
                            file.Cells[10].Value = cantidevoculion * costodevolucion;
                            file.Cells[11].Value = totalgabinete;
                            file.Cells[12].Value = costodevolucion;
                            file.Cells[13].Value = totalgabinete * costodevolucion;


                        }
                        else
                        {
                            if (cbinventario.Text == "monitor")
                            {
                                totalmonitor = totalmonitor - cantidevoculion;
                                file.Cells[0].Value = (FECHA);
                                file.Cells[1].Value = (cbinventario.Text);
                                file.Cells[8].Value = cantidevoculion;
                                file.Cells[9].Value = costodevolucion;
                                file.Cells[10].Value = cantidevoculion * costodevolucion;
                                file.Cells[11].Value = totalmonitor;
                                file.Cells[12].Value = costodevolucion;
                                file.Cells[13].Value = totalmonitor * costodevolucion;


                            }
                            else
                            {
                                if (cbinventario.Text == "disipador")
                                {
                                    totaldisipador = totaldisipador - cantidevoculion;
                                    file.Cells[0].Value = (FECHA);
                                    file.Cells[1].Value = (cbinventario.Text);
                                    file.Cells[8].Value = cantidevoculion;
                                    file.Cells[9].Value = costodevolucion;
                                    file.Cells[10].Value = cantidevoculion * costodevolucion;
                                    file.Cells[11].Value = totaldisipador;
                                    file.Cells[12].Value = costodevolucion;
                                    file.Cells[13].Value = totaldisipador * costodevolucion;


                                }


                            }
                        }
                    }
                }


            }












            grid.Rows.Add(file);

            //calculo de columnas 
            double total = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {

                total += Convert.ToDouble(row.Cells["column3"].Value);

            }

            txttotal.Text = Convert.ToString(total);

            double totalex = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {

                totalex += Convert.ToDouble(row.Cells["column10"].Value);

            }

            txtotalexis.Text = Convert.ToString(totalex);

            double totalsl = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {

                totalsl += Convert.ToDouble(row.Cells["column7"].Value);

            }

            txtotalsalida.Text = Convert.ToString(totalsl);


            //borrar espacios 
            txcantidad.Text = txcostou.Text  = txcostos.Text = txcantidads.Text = txcostdevo.Text = txcandevol.Text = "0";
            cbinventario.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txfecha_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void XX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txcantidads_TextChanged(object sender, EventArgs e)
        {

        }

        private void CALCULAR2_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();


            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
    
