   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.ReporteGeneral   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� Title$  ReporteGeneral��5	       N� 
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
��Auto �6     � ColumnDefinitions 5       �� 5!      $��* �6#   .+�5#      �� $��0��6   $��0��6$   $��Center=�61   .��5$      �� $
��Wrap=�6    �� TextAlignment$ Center=�61   $
��Bold"�6S   $��14(�6o   REPORTE GENERAL5&      5'      �� 5)      $��0��6   $��1��6$   .��5*      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Ésta opción me permitirá visualizar un reporte de la cantidad total de comprobantes Aceptados, Rechazados, Sin Estado, De Baja, y emitidos en el rango de fecha seleccionado.�� 5+   �   ��El reporte de totales se divide en reporte total de Facturas electrónicas y sus notas asociadas; y reporte total de Boletas de venta electrónicas y sus notas asociadas.�� 5,   �   }Previo a la generación del reporte deseado, se podrá realizar una búsqueda filtrando por: Fecha de Inicio, y Fecha de Fin.�� 5-   |   5.      5/      �� 50      $��0��6   $��2��6$   $��Center=�61   $4��./FEI;component/images/ayuda_reporteGeneral.png��6N   $
��None=�6�   �� 51      $��0��6   $��3��6$   .��53      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Previo a la generación del reporte deseado, se podrá realizar una búsqueda de las facturas electrónicas y notas asociadas a través de los filtros que considere.�� 54   �   ��Se tiene la posibilidad de filtrar por: Tipo de comprobante, Estado de comprobantes en SCC, Estado de comprobante en SUNAT, Fecha de inicio y Fecha de Fin de emisión.�� 55   �   57      58      �� 59      $��0��6   $��4��6$   $��Center=�61   $<��6/FEI;component/images/ayuda_reporteGeneral_Ventana.png��6N   $
��Fill=�6�   �� 5:      $��0��6   $��6��6$   .��5;      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5<      .�6   -+Reporte en Excel y/o PDF de Reporte General6D   �� 6J   DBPasos para realizar la generación de una reporte en PDF o en CSV:�� 5=   P   YW►En la parte inferior derecha, se muestra la opción de “Generación de Reporte”.�� 5>   a   sq►Se seleccionará el tipo de archivo para reporte que se desee, y luego se presionará el botón “Reporte”.�� 5?   z   5@      5A      �� 5B      $��0��6   $��7��6$   $��Center=�61   $=��7/FEI;component/images/ayuda_reporteFE_VentanaSelect.png��6N   $
��None=�6�   �� 5C      $��0��6   $��8��6$   .��5D      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   XVA continuación se mostrará la siguiente ventana emergente, la cual se ha de aceptar:5F      5G      �� 5H      $��0��6   $��9��6$   $��Center=�61   $C��=/FEI;component/images/ayuda_reporteFE_VentanaConfirmacion.png��6N   $
��None=�6�   �� 5I      $��0��6   $��10��6$   .��5J      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   KISe ingresará a la ruta de almacenamiento de reportes (Ruta de archivos):5L      5M      �� 5N      $��0��6   $��11��6$   $��Center=�62   $;��5/FEI;component/images/ayuda_reporteFE_VentanaRuta.png��6O   $
��None=�6�   �� 5O      $��0��6   $��12��6$   .��5P      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��► El Reporte General mostrará un Reporte dividido en Facturas electrónicas y notas asociadas, y Boletas de venta electrónicas y notas asociadas.�� 5Q   �   ��► El encabezado de columnas tendrá la siguiente descripción: NOMBRE DE COMPROBANTE, CÓDIGO, ACEPTADOS, RECHAZADOS, SIN ESTADO, DE BAJA, EMITIDOS.5T      5U      �� 5V      $��0��6   $��13��6$   .��5W      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5X      .�6   REPORTE PDF6    (& , se mostrará de la siguiente forma:5Y      5Z      �� 5[      $��0��6   $��14��6$   $��Center=�62   $?��9/FEI;component/images/ayuda_reporteGeneral_VentanaPDF.png��6O   $
��Fill=�6�   �� 5]      $��0��6   $��15��6$   .��5^      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5_      .�6   REPORTE CSV6    (& , se mostrará de la siguiente forma:5`      5a      �� 5b      $��0��6   $��16��6$   $��Center=�62   $?��9/FEI;component/images/ayuda_reporteGeneral_VentanaCSV.png��6O   $
��Fill=�6�   5c      5d      5e      