   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.RA   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� Title$  RA��5	       N� 
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
��Auto �6     � ColumnDefinitions 5"      �� 5#      $��* �6#   .+�5%      �� $��0��6   $��0��6$   $��Center=�61   .��5&      �� $
��Wrap=�6    �� TextAlignment$ Center=�61   $
��Bold"�6S   $��14(�6o   GENERAR COMUNICACIÓN DE BAJA5(      5)      �� 5+      $��0��6   $��1��6$   .��5,      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   rpEn ésta opción sólo se visualizarán los comprobantes electrónicos a los cuáles se podrá realizar la baja:�� 5-   ~   VT► Facturas Electrónicas y sus notas asociadas que hayan sido Aceptadas por SUNAT.�� 5.   S   ��► Boletas de Venta Electrónicas y sus notas asociadas que hayan sido generadas, y se encuentren Sin Estado, es decir aún no han sido enviadas a SUNAT mediante Resumen Diario.�� 5/   �   ��► Boletas de Venta Electrónicas y sus notas asociadas que hayan sido generadas, y se encuentren Aceptadas, es decir han sido enviadas a SUNAT mediante Resumen Diario.�� 50   �   52      53      �� 54      $��0��6   $��2��6$   $��Center=�61   $(��"/FEI;component/images/ayuda_RA.png��6N   $
��None=�6z   �� 55      $��0��6   $��3��6$   .��57      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Se deberán de seleccionar las Boletas de Venta Electrónicas y/o sus notas asociadas, Facturas Electrónicas y/o sus notas asociadas, a los cuales se desean realizar una Comunicación de Baja ante SUNAT, y luego presionar el botón “Agregar a comunicación de baja”.59      5:      �� 5;      $��0��6   $��4��6$   $��Center=�61   $0��*/FEI;component/images/ayuda_RA_Ventana.png��6N   $
��Fill=�6�   �� 5<      $��0��6   $��5��6$   .��5>      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5?      .�6   Nota6   �� Si se selecciona a todo un grupo de Boletas de Venta Electrónicas y/o sus notas asociadas, Facturas Electrónicas y/o sus notas asociadas, que correspondan a días diferentes, entonces se generará una Comunicación de Baja por cada día. Recordar que la Comunicación de Baja agrupará a todo un grupo de documentos que tengan una misma fecha de emisión.5@      5A      �� 5B      $��0��6   $��6��6$   .��5C      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��A continuación se mostrará un mensaje de alerta, para confirmar si ¿Ésta seguro que desea enviar a comunicación de baja los documentos seleccionados?, teniendo la posibilidad de aceptar haciendo click en “SI” o verificar nuevamente haciendo click en “NO”.5E      5F      �� 5G      $��0��6   $��7��6$   $��Center=�61   $<��6/FEI;component/images/ayuda_RA_VentanaConfirmacion.png��6N   $
��None=�6�   �� 5H      $��0��6   $��8��6$   .��5I      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Luego de se mostrará la siguiente ventana, que indica que los documentos están siendo procesados para agregar a una nueva Comunicación de Baja.5L      5M      �� 5N      $��0��6   $��9��6$   $��Center=�61   $5��//FEI;component/images/ayuda_FEVentana_Carga.png��6N   $
��None=�6�   �� 5O      $��0��6   $��10��6$   .��5P      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Una vez generado la comunicacion de baja, se mostrará el siguiente mensaje: LOS DOCUMENTOS SE AGREGARON A SU RESPECTIVA COMUNICACIÓN DE BAJA5R      5S      �� 5T      $��0��6   $��11��6$   $��Center=�62   $7��1/FEI;component/images/ayuda_RA_VentanaMensaje.png��6O   $
��None=�6�   �� 5U      $��0��6   $��12��6$   .��5V      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Luego de ingresar a la opción “Generar Comunicación de Baja”, tendrá que ingresar a la opción “Envío a SUNAT y Consulta de Ticket de RA; ahí recién se completaría el envío de una Comunicación de Baja.5X      5Y      5[      5\      5]      