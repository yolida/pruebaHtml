   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.ReporteBV   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� Title$  	ReporteBV��5	       N� 
Background
 �����.��5      �� $��Visible=�6   .��5   
   � $��10q�6    � RowDefinitions 5      �� 5      $
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
��Auto �6     � ColumnDefinitions 5!      �� 5"      $��* �6#   .+�5$      �� $��0��6   $��0��6$   $��Center=�61   .��5%      �� $
��Wrap=�6    �� TextAlignment$ Center=�61   $
��Bold"�6S   $��14(�6o   REPORTE DE BOLETAS DE VENTA5'      5(      �� 5*      $��0��6   $��1��6$   .��5+      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Ésta opción me permitirá visualizar un reporte de todas las Boletas de Venta Electronica generadas asi como sus Notas de Crédito y Débito.5-      5.      �� 5/      $��0��6   $��2��6$   $��Center=�61   $/��)/FEI;component/images/ayuda_reporteBV.png��6N   $
��None=�6�   �� 50      $��0��6   $��3��6$   .��52      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Previo a la generación del reporte deseado, se podrá realizar una búsqueda de las facturas electrónicas y notas asociadas a través de los filtros que considere.�� 53   �   ��Se tiene la posibilidad de filtrar por: Tipo de comprobante, Estado de comprobantes en SCC, Estado de comprobante en SUNAT, Fecha de inicio y Fecha de Fin de emisión.�� 54   �   56      57      �� 58      $��0��6   $��4��6$   $��Center=�61   $7��1/FEI;component/images/ayuda_reporteBV_Ventana.png��6N   $
��Fill=�6�   �� 59      $��0��6   $��5��6$   .��5;      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ^\Los “Estados de comprobante en SUNAT” para boletas y notas asociadas son los siguientes:�� 5<   h   ► �� 5=      .�6	   	ACEPTADO:6   [YEl comprobante cumple con las validaciones establecidas, por tanto es aceptado por SUNAT.�� 6s   ► �� 5>      .�6	   
RECHAZADO:6   ��El comprobante cumple con las validaciones establecidas, por tanto se deberá de emitir un nuevo comprobante con correlativo siguiente. En este caso, el comprobante de pago electrónico que se hubiera emitido, no tiene validez tributaria.�� 6  ► �� 5?      .�6	   SIN ESTADO:6   {yEl comprobante aún no es validado por SUNAT, ya sea por error en la red del cliente, o por error en la webservice SUNAT.�� 6�   ► �� 5@      .�6	   
DE BAJA:6   \ZEl comprobante fue anulado por el contribuyente, en los plazos y forma prevista por SUNAT.�� 6s   5B      5C      �� 5D      $��0��6   $��6��6$   .��5E      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5F      .�6   -+Reporte en Excel y/o PDF de Boleta de Venta6D   �� 6J   DBPasos para realizar la generación de una reporte en PDF o en CSV:�� 5G   P   YW►En la parte inferior derecha, se muestra la opción de “Generación de Reporte”.�� 5H   a   sq►Se seleccionará el tipo de archivo para reporte que se desee, y luego se presionará el botón “Reporte”.�� 5I   z   5J      5K      �� 5L      $��0��6   $��7��6$   $��Center=�61   $=��7/FEI;component/images/ayuda_reporteFE_VentanaSelect.png��6N   $
��None=�6�   �� 5M      $��0��6   $��8��6$   .��5N      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   XVA continuación se mostrará la siguiente ventana emergente, la cual se ha de aceptar:5P      5Q      �� 5R      $��0��6   $��9��6$   $��Center=�61   $C��=/FEI;component/images/ayuda_reporteFE_VentanaConfirmacion.png��6N   $
��None=�6�   �� 5S      $��0��6   $��10��6$   .��5T      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   KISe ingresará a la ruta de almacenamiento de reportes (Ruta de archivos):5V      5W      �� 5X      $��0��6   $��11��6$   $��Center=�62   $;��5/FEI;component/images/ayuda_reporteFE_VentanaRuta.png��6O   $
��None=�6�   �� 5Y      $��0��6   $��12��6$   .��5Z      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��El encabezado de columnas tendrá la siguiente descripción: CÓDIGO, TIPO DE COMPROBANTE, SERIE-NÚMERO, ESTADO SCC, ESTADO SUNAT, FECHA DE EMISIÓN, DECHA DE ENVÍO, RUC, RAZÓN SOCIAL, COMENTARIO SUNAT.5\      5]      �� 5^      $��0��6   $��13��6$   .��5_      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5`      .�6   REPORTE PDF6    (& , se mostrará de la siguiente forma:5a      5b      �� 5c      $��0��6   $��14��6$   $��Center=�62   $:��4/FEI;component/images/ayuda_reporteBV_VentanaPDF.png��6O   $
��Fill=�6�   �� 5e      $��0��6   $��15��6$   .��5f      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5g      .�6   REPORTE CSV6    (& , se mostrará de la siguiente forma:5h      5i      �� 5j      $��0��6   $��16��6$   $��Center=�62   $:��4/FEI;component/images/ayuda_reporteBV_VentanaCSV.png��6O   $
��Fill=�6�   5l      5m      5n      