﻿using SysCredito.model.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SysCredito.ventana;
using SysCredito.EntiteFramework;
using System.Windows.Forms;

namespace SysCredito
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void iniciarSesion(object sender, RoutedEventArgs e)
        {

            String user = txt_Usuario.Text;
            String pass = txt_Password.Password;
            usuariosistema usuarioSistema;

            if (user != "" && pass != "")
            {

                try
                {
                    usuarioSistema = UsuarioSistemaDAO.login(user, pass);

                    if (usuarioSistema == null)
                    {
                        System.Windows.MessageBox.Show(" No existe el usuario  ");
                    }
                    else
                    {

                        int rol = usuarioSistema.rol_idrol;
                        String nombreUsuario = usuarioSistema.nombre;
                        String noEmpleado = usuarioSistema.numempleado;
                        switch (rol)
                        {
                            case 1:
                                GUIAsesorprincipal guiAsesorprincipal = new GUIAsesorprincipal();
                                guiAsesorprincipal.Show();
                                guiAsesorprincipal.lbNombre.Content = nombreUsuario;
                                guiAsesorprincipal.lbNoEmpleado.Content = noEmpleado;
                                closeWindows();
                               break;
        
                            case 2:
                                GUIAnalistaPrincipal gUIAnalistaPrincipal = new GUIAnalistaPrincipal();
                                gUIAnalistaPrincipal.Show();
                                gUIAnalistaPrincipal.lbNombre.Content = nombreUsuario;
                                gUIAnalistaPrincipal.lbNoEmpleado.Content = noEmpleado;
                                closeWindows();
                                break;
                            case 3:
                                GUIAdministradorPrincipal gUIAdministradorPrincipal = new GUIAdministradorPrincipal();
                                gUIAdministradorPrincipal.Show();
                                gUIAdministradorPrincipal.lbNombre.Content = nombreUsuario;
                                gUIAdministradorPrincipal.lbNoEmpleado.Content = noEmpleado;
                                closeWindows();
                                break;

                        }

                    }
                }
                catch (Exception ex)
                {
                    String str = ex.Message;
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Ingrese un usuario y una contraseña");
            }
        }
        

        public void closeWindows()
        {
            this.Close();
        }

    }
}