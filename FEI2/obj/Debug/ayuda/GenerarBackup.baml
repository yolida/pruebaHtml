   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.GenerarBackup   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� Title$  GenerarBackup��5	       N� 
Background
 �����.��5
      �� $��Visible=�6   .��5   
   � $��10q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
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
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6     � ColumnDefinitions 5$      �� 5%      $��* �6#   .+�5'      �� $��0��6   $��0��6$   $��Center=�61   .��5(      �� $
��Wrap=�6    �� TextAlignment$ Center=�61   $
��Bold"�6S   $��14(�6o   GENERACIÓN DE BACKUP5*      5+      �� 5-      $��0��6   $��1��6$   .��5.      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Ésta opción permitirá realizar una copia de seguridad por una o todas las empresas registradas. Para ello ingresará a la opción Utilitarios y por último la opción generación de backup.�� 5/   �   50      51      �� 52      $��0��6   $��2��6$   $��Center=�61   $1��+/FEI;component/images/ayuda_UGeneracion.png��6N   $
��None=�6�   �� 53      $��0��6   $��3��6$   .��55      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Se mostrará la siguiente ventana, misma que tendrá dos opciones para generar backup, por usuario actual y por todas las empresas.57      58      �� 59      $��0��6   $��4��6$   $��Center=�61   $9��3/FEI;component/images/ayuda_UGeneracion_Ventana.png��6N   $
��Fill=�6�   �� 5:      $��0��6   $��5��6$   .��5;      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5<      .�6   BACKUP DE USUARIO ACTUAL62   �� 6:   ^\Éste rubro me permite generar un backup de la empresa actual en la que se está trabajando.�� 5=   ^   zxPara ello nos dirigimos al botón “Examinar”, para seleccionar la ruta donde deseamos guardar la copia de seguridad.�� 5>   v   5@      5A      �� 5B      $��0��6   $��6��6$   5D      �� 5E      $��0��6   $��7��6$   $��Center=�61   $>��8/FEI;component/images/ayuda_UGeneracion_UsuarioUnico.png��6N   $
��Fill=�6�   �� 5F      $��0��6   $��8��6$   .��5G      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Una vez seleccionada la ruta, y antes de presionar el botón “Generar”, de forma opcional se podrá colocar una contraseña se acceso al backup, en caso no se desee ello, sólo dará click en el botón “Generar”.5H   �   5I      �� 5J      $��0��6   $��9��6$   $��Center=�61   $A��;/FEI;component/images/ayuda_UGeneracion_UsuarioUnicoDos.png��6N   $
��Fill=�6�   �� 5L      $��0��6   $��10��6$   .��5M      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �Luego de presionar el botón “Generar”, se mostrará la siguiente ventana, que indica que se está procesando la solicitud.5O      5P      �� 5Q      $��0��6   $��11��6$   $��Center=�62   $5��//FEI;component/images/ayuda_FEVentana_Carga.png��6O   $
��None=�6�   �� 5R      $��0��6   $��12��6$   .��5S      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ywUna vez generada la copia de seguridad se mostrará el siguiente mensaje: “SE HA GENERADO CORRECTAMENTE EL BACKUP”.5U      5V      �� 5W      $��0��6   $��13��6$   $��Center=�62   $9��3/FEI;component/images/ayuda_UGeneracion_Mensaje.png��6O   $
��None=�6�   �� 5X      $��0��6   $��14��6$   .��5Y      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5Z      .�6   0.BACKUP DE TODA LA INFORMACIÓN DE LAS EMPRESAS6@   �� 6H   ��Éste rubro me permite generar un backup de todas las empresas que hayan sido antes creadas en el Sistema de Facturación Electrónica Integrado.�� 5[   �   ��Para ello primero seleccionamos todas o algunas empresas a las cuales les deseamos generar una copia de seguridad, luego presionamos el botón “Examinar”, para seleccionar la ruta donde deseamos guardar la copia de seguridad.�� 5\   �   5^      5_      �� 5`      $��0��6   $��15��6$   $��Center=�62   $7��1/FEI;component/images/ayuda_UGeneracion_Todos.png��6O   $
��Fill=�6�   �� 5a      $��0��6   $��16��6$   .��5b      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Una vez seleccionada la ruta, y antes de presionar el botón “Generar”, de forma opcional se podrá colocar una contraseña se acceso al backup, en caso no se desee ello, sólo dará click en el botón “Generar”.5d      5e      �� 5f      $��0��6   $��17��6$   $��Center=�62   $:��4/FEI;component/images/ayuda_UGeneracion_TodosDos.png��6O   $
��Fill=�6�   �� 5g      $��0��6   $��18��6$   .��5h      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �Luego de presionar el botón “Generar”, se mostrará la siguiente ventana, que indica que se está procesando la solicitud.5j      5k      �� 5l      $��0��6   $��19��6$   $��Center=�62   $5��//FEI;component/images/ayuda_FEVentana_Carga.png��6O   $
��None=�6�   �� 5m      $��0��6   $��20��6$   .��5n      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ywUna vez generada la copia de seguridad se mostrará el siguiente mensaje: “SE HA GENERADO CORRECTAMENTE EL BACKUP”.5p      5q      �� 5r      $��0��6   $��21��6$   $��Center=�62   $9��3/FEI;component/images/ayuda_UGeneracion_Mensaje.png��6O   $
��None=�6�   5t      5u      5v      