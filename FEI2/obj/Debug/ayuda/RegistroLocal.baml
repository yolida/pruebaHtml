   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.RegistroLocal   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� Title$  RegistroLocal��5	       N� 
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
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6     � ColumnDefinitions 5#      �� 5$      $��* �6#   .+�5&      �� $��0��6   $��0��6$   $��Center=�61   .��5'      �� $
��Wrap=�6    �� TextAlignment$ Center=�61   $
��Bold"�6S   $��14(�6o   A?ALMACEN DE REGISTRO LOCAL (CONFIGURACIÓN DE BASE DE DATOS SQL)5)      5*      �� 5,      $��0��6   $��1��6$   .��5-      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Ésta opción me permite configurar y crear una base de datos para almacenamiento de todos los documentos electrónicos. Para ello se ingresará a la opción Configuración del Sistema, opción “Almacén de registro local”.5/      50      �� 51      $��0��6   $��2��6$   $��Center=�61   $,��&/FEI;component/images/ayuda_CLocal.png��6N   $
��None=�6~   �� 52      $��0��6   $��3��6$   .��54      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   42A continuación se mostrará la siguiente ventana:56      57      �� 58      $��0��6   $��4��6$   $��Center=�61   $4��./FEI;component/images/ayuda_CLocal_Ventana.png��6N   $
��None=�6�   �� 59      $��0��6   $��5��6$   .��5;      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5<      .�6   Nota6   �� El sistema requiere de una conexión ODBC; por lo tanto asegúrese de contar con el driver apropiado para su sistema operativo.5=      5>      �� 5?      $��0��6   $��6��6$   .��5@      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ,*Los campos a completar son los siguientes:�� 5A   ?   ► �� 5C      .�6	   	Gestor BD6   TR: Se podrá escoger entre las bases de datos: Microsoft SQL Server, MySQL, SQLite.�� 6l   ��- Para configurar en PC´s de usuarios internos con el fin de realizar pruebas e instalaciones rápidas), se recomienda trabajar con base de datos SQLite.�� 5D   �   ��- Para configurar en PC’s de usuario externos, se recomienda trabajar con base de datos Microsoft SQL Server Express o licenciado, depende del cliente.�� 5E   �   ► �� 5F      .�6	   Driver de Gestor BD (ODBC)6%   }{: En éste caso se escogió Microsoft SQL Server, por lo tanto le corresponde como driver de gestor sea igual a SQL Server.�� 6�   ► �� 5G      .�6	   Servidor BD6   ][: Es el nombre de la instancia que se indicó al momento de la instalación del SQL Server.�� 6u   ► �� 5H      .�6	   Puerto del Servidor BD6!   ��: Por default el puerto habilitado para conexión de Base de Datos es el puerto 1433, a menos que al momento de la instalación del SQL Server se haya indicado otro puerto para conexión de base de datos.�� 6�   ► �� 5I      .�6	   Nombre de base de datos6"   :8:Se podrá poner el nombre que se considere conveniente.�� 6_   ► �� 5J      .�6	   	Usuario6   }{: Se habilitará un usuario en el SQL Server para manejo de la base de datos FEI, mismo que será ingresado en éste campo.�� 6�   ► �� 5K      .�6	   Contraseña6   ��:El usuario habilitado para manejo de la base de datos FEI, tendrá una contraseña se acceso por seguridad, misma que será ingresada en éste campo.�� 6�   ��Luego de ingresar todos los datos necesarios para crear la base de datos, se procederá a presionar el botón “Crear Base de Datos”.5O      5P      �� 5Q      $��0��6   $��7��6$   $��Center=�61   $7��1/FEI;component/images/ayuda_CLocal_VentanaDos.png��6N   $
��None=�6�   �� 5R      $��0��6   $��8��6$   .��5S      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Luego de presionar el botón “Crear base de datos”, se creará una Base de Datos para el Sistema FEI con las tablas y estructuras correspondientes.5U      5V      �� 5W      $��0��6   $��10��6$   .��5X      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5Y      .�6   DBCAMBIAR LA BASE DE DATOS Y/O ACTUALIZAR INFORMACIÓN LA CONEXIÓN.6Y   �� 6`   ��En caso se desee cambiar y/o actualizar el gestor de Base de datos, el nombre de la base de datos, puerto, usuario de acceso, o cambiar base de datos, se podrá proceder a realizar los cambios necesarios y presionará el botón “Guardar” para mantener todos los cambios.5\      5]      �� 5^      $��0��6   $��11��6$   $��Center=�62   $8��2/FEI;component/images/ayuda_CLocal_VentanaTres.png��6O   $
��None=�6�   �� 5_      $��0��6   $��12��6$   .��5`      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   qoLuego de presionar el botón “Guardar”, se mostrará el siguiente mensaje al cual le daremos “Aceptar”.5b      5c      �� 5d      $��0��6   $��13��6$   $��Center=�62   $<��6/FEI;component/images/ayuda_CLocal_VentanaCorrecto.png��6O   $
��None=�6�   �� 5e      $��0��6   $��14��6$   .��5f      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��En caso se presione el botón “Crear base de datos”, sin haber antes cambiado el nombre de la BD, se mostrará la siguiente advertencia, el cual sólo aceptaremos, porque nos indica que la base de datos Ya Existe.5h      5i      �� 5j      $��0��6   $��15��6$   $��Center=�62   $9��3/FEI;component/images/ayuda_CLocal_VentanaError.png��6O   $
��None=�6�   5l      5m      5n      