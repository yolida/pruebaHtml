   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.RD   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� Title$  RD��5	       N� 
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
��Bold"�6S   $��14(�6o   GENERAR RESUMEN DIARIO5)      5*      �� 5,      $��0��6   $��1��6$   .��5-      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   CAÉsta opción permite generar manualmente los Resúmenes Diarios.�� 5.   U   ��En ésta opción sólo se visualizarán las Boletas de Venta Electrónicas y notas asociadas que se encuentren SIN ESTADO, es decir que aún no han sido agregadas a algún Resumen Diario.�� 5/   �   51      52      �� 53      $��0��6   $��2��6$   $��Center=�61   $/��)/FEI;component/images/ayuda_RDGenerar.png��6N   $
��None=�6�   �� 54      $��0��6   $��3��6$   .��56      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Se deberán de seleccionar las Boletas de Venta Electrónicas y notas asociadas que agregarse a algún Resumen Diario, y luego presionar el botón “Resumen Diario”.58      59      �� 5:      $��0��6   $��4��6$   $��Center=�61   $7��1/FEI;component/images/ayuda_RDGenerar_Ventana.png��6N   $
��Fill=�6�   �� 5;      $��0��6   $��5��6$   .��5=      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5>      .�6   Nota6   �� Si se selecciona a todo un grupo de Boletas de Ventas electrónicas y sus notas asociadas, que correspondan a días diferentes, entonces se generará un Resumen Diario por cada día. Recordar que el Resumen Diario agrupará a todo un grupo de documentos que tengan una misma fecha de emisión.5?      5@      �� 5A      $��0��6   $��6��6$   .��5B      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��A continuación se mostrará un mensaje de alerta, para confirmar si ¿Ésta seguro que desea enviar a resumen diario los documentos seleccionados?, teniendo la posibilidad de aceptar haciendo click en “SI” o verificar nuevamente haciendo click en “NO”.5D      5E      �� 5F      $��0��6   $��7��6$   $��Center=�61   $C��=/FEI;component/images/ayuda_RDGenerar_VentanaConfirmacion.png��6N   $
��None=�6�   �� 5G      $��0��6   $��8��6$   .��5H      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Luego de se mostrará la siguiente ventana, que indica que los documentos están siendo procesados para agregar a un nuevo Resumen Diario.5K      5L      �� 5M      $��0��6   $��9��6$   $��Center=�61   $5��//FEI;component/images/ayuda_FEVentana_Carga.png��6N   $
��None=�6�   �� 5N      $��0��6   $��10��6$   .��5O      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Una vez generado el Resumen Diario, se mostrará el siguiente mensaje: TODOS LOS DOCUMENTOS SE AGREGARON A SU RESPECTIVO RESUMEN DIARIO.5Q      5R      �� 5S      $��0��6   $��11��6$   $��Center=�62   $>��8/FEI;component/images/ayuda_RDGenerar_VentanaMensaje.png��6O   $
��None=�6�   �� 5T      $��0��6   $��12��6$   .��5U      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��A continuación ya NO se mostrarán las Boletas de Venta Electrónicas y notas asociadas en la ventana de “Agregar a Resumen Diario”.5W      5X      �� 5Y      $��0��6   $��13��6$   $��Center=�62   $=��7/FEI;component/images/ayuda_RDGenerar_VentanaBlanco.png��6O   $
��Fill=�6�   �� 5Z      $��0��6   $��14��6$   .��5[      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Luego de ingresar a la opción “Generar Resumen Diario”, tendrá que ingresar a la opción “Envío a SUNAT y Consulta de Ticket de RC; ahí recién se completaría el envío de un Resumen Diario (Boletas de Venta Electrónicas y sus notas asociadas).5]      5^      5`      5a      5b      