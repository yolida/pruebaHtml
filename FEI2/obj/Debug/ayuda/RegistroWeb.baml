   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.RegistroWeb   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� Title$  RegistroWeb��5	       N� 
Background
 �����.��5      �� $��Visible=�6   .��5   
   � $��10q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6     � ColumnDefinitions 5#      �� 5$      $��* �6#   .+�5&      �� $��0��6   $��0��6$   $��Center=�61   .��5'      �� $
��Wrap=�6    �� TextAlignment$ Center=�61   $
��Bold"�6S   $��14(�6o   DBALMACEN DE REGISTROS WEB (CONFIGURACIÓN DE BASE DE DATOS SQL WEB)5)      5*      �� 5,      $��0��6   $��1��6$   .��5-      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Ésta opción me permite configurar y crear una base de datos web, para almacenar todos los comprobantes electrónicos ACEPTADOS por SUNAT, mismos que podrán ser consultados mediante página web (Hosting) del emisor electrónico.�� 5.   �   a_Se ingresará a la opción Configuración del Sistema, opción “Almacén de registros web”.51      52      �� 53      $��0��6   $��2��6$   $��Center=�61   $*��$/FEI;component/images/ayuda_CWeb.png��6N   $
��None=�6|   �� 54      $��0��6   $��3��6$   .��56      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   42A continuación se mostrará la siguiente ventana:58      59      �� 5:      $��0��6   $��4��6$   $��Center=�61   $2��,/FEI;component/images/ayuda_CWeb_Ventana.png��6N   $
��None=�6�   �� 5;      $��0��6   $��5��6$   �� 5<      $��0��6   $��6��6$   .��5=      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ► �� 5>      .�6   	Gestor BD6%   )': Se escogerá BD Microsoft SQL Server.�� 6R   ► �� 5?      .�6	   Driver de Gestor BD (ODBC)6%   &$: Se escogerá Microsoft SQL Server.�� 6O   ► �� 5@      .�6	   Servidor BD6   ][: Es el nombre de la instancia que se indicó al momento de la instalación del SQL Server.�� 6v   ► �� 5A      .�6	   Puerto del Servidor BD6!   ��: Por default el puerto habilitado para conexión de Base de Datos es el puerto 1433, a menos que al momento de la instalación del SQL Server se haya indicado otro puerto para conexión de base de datos.�� 6�   ► �� 5B      .�6	   Nombre de base de datos6"   :8:Se podrá poner el nombre que se considere conveniente.�� 6`   ► �� 5C      .�6	   	Usuario6   }{: Se habilitará un usuario en el SQL Server para manejo de la base de datos FEI, mismo que será ingresado en éste campo.�� 6�   ► �� 5D      .�6	   Contraseña6   ��:El usuario habilitado para manejo de la base de datos FEI, tendrá una contraseña se acceso por seguridad, misma que será ingresada en éste campo.�� 6�   ��Luego de ingresar todos los datos necesarios para crear la base de datos, se procederá a presionar el botón “Crear Base de Datos”.�� 5F   �   5H      5I      �� 5J      $��0��6   $��7��6$   $��Center=�61   $5��//FEI;component/images/ayuda_CWeb_VentanaUno.png��6N   $
��None=�6�   �� 5K      $��0��6   $��8��6$   .��5L      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Luego de presionar el botón “Crear base de datos”, se creará una Base de Datos para el Sistema FEI en WEB, con las tablas y estructuras correspondientes.5N      5O      �� 5P      $��0��6   $��10��6$   .��5Q      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5R      .�6   HFCAMBIAR LA BASE DE DATOS WEB Y/O ACTUALIZAR INFORMACIÓN LA CONEXIÓN.6]   �� 6d   ��En caso se desee cambiar y/o actualizar el gestor de Base de datos web, el nombre de la base de datos, puerto, usuario de acceso, o cambiar base de datos, se podrá proceder a realizar los cambios necesarios y presionará el botón “Guardar” para mantener todos los cambios.5U      5V      �� 5W      $��0��6   $��11��6$   $��Center=�62   $5��//FEI;component/images/ayuda_CWeb_VentanaDos.png��6O   $
��None=�6�   �� 5X      $��0��6   $��12��6$   .��5Y      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   qoLuego de presionar el botón “Guardar”, se mostrará el siguiente mensaje al cual le daremos “Aceptar”.5[      5\      �� 5]      $��0��6   $��13��6$   $��Center=�62   $<��6/FEI;component/images/ayuda_CLocal_VentanaCorrecto.png��6O   $
��None=�6�   �� 5^      $��0��6   $��14��6$   .��5_      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��En caso se presione el botón “Crear base de datos”, sin haber antes cambiado el nombre de la BD, se mostrará la siguiente advertencia, el cual sólo aceptaremos, porque nos indica que la base de datos Ya Existe.5a      5b      �� 5c      $��0��6   $��15��6$   $��Center=�62   $7��1/FEI;component/images/ayuda_CWeb_VentanaError.png��6O   $
��None=�6�   5e      5f      5g      