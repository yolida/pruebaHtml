   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.ReporteRA   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� Title$  	ReporteRA��5	       N� 
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
��Bold"�6S   $��14(�6o   " REPORTE DE COMUNICACIÓN DE BAJA5)      5*      �� 5,      $��0��6   $��1��6$   .��5-      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Ésta opción permitirá visualizar un reporte de todas las Comunicaciones de Baja generadas, bajas de facturas electrónicas y sus notas asociadas, baja deboletas de venta electrónicas y sus notas asociadas.5/      50      �� 51      $��0��6   $��2��6$   $��Center=�61   $/��)/FEI;component/images/ayuda_reporteRA.png��6N   $
��None=�6�   �� 52      $��0��6   $��3��6$   .��54      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Previo a la generación del reporte deseado, se podrá realizar una búsqueda de las Comunicaciones de baja, a través de los filtros que considere.�� 55   �   geTiene la posibilidad de filtrar por: Estado de comprobante en SUNAT, Fecha de Inicio, y Fecha de Fin.57      58      �� 59      $��0��6   $��4��6$   $��Center=�61   $7��1/FEI;component/images/ayuda_reporteRA_Ventana.png��6N   $
��Fill=�6�   �� 5:      $��0��6   $��5��6$   .��5<      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ZXLos “Estados de comprobante en SUNAT” para Comunicación de Baja son los siguientes:�� 5=   a   ► �� 5>      .�6	   
ACEPTADO6   ge: La Comunicación de Baja cumple con las validaciones establecidas, por tanto es aceptado por SUNAT.�� 6}   ► �� 5?      .�6	   	RECHAZADO6   ��: La Comunicación de Baja no cumple con las validaciones establecidas, por tanto se deberá de generar una nueva Comunicación de Baja con correlativo siguiente. En este caso, ninguno de los comprobantes de pago electrónicos que hubieran estado incluidos en la dicha Comunicación de Baja, aún no estarán dados de baja o anulados. ► �� 5A      .�6	   
SIN ESTADO6   ��: La Comunicación de Baja aún no es validada por SUNAT, ya sea por error en la red del cliente, o por error en la webservice SUNAT.�� 6�   5C      5D      �� 5E      $��0��6   $��6��6$   .��5F      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5G      .�6   " Detalle de Comunicación de Baja68   �� 6?   ��En el Reporte de Comunicación de Baja, se podrá visualizar cuáles son los documentos que están incluidos en cada Comunicación de Baja.�� 5H   �   ��Para poder saber cuáles son los documentos que están incluidos en cada Comunicación de Baja, deberá de seleccionar la fila de la Comunicación de Baja que desea consultar, de seleccionar tal cual se muestra en la imagen en el PASO 1.�� 5I   �   ��Luego en la parte inferior en “Detalle de Comunicación de Baja”, se mostrarán el detalle de todos los documentos incluidos, tal cual se muestra en la imagen en el PASO 2.�� 5J   �   5L      5M      �� 5N      $��0��6   $��7��6$   $��Center=�61   $;��5/FEI;component/images/ayuda_reporteRA_VentanaOtro.png��6N   $
��Fill=�6�   �� 5O      $��0��6   $��8��6$   .��5P      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5Q      .�6   31Reporte en Excel y/o PDF de COMUNICACIÓN DE BAJA6I   �� 6O   DBPasos para realizar la generación de una reporte en PDF o en CSV:�� 5R   C   ZX► En la parte inferior derecha, se muestra la opción de “Generación de Reporte”.�� 5S   R   tr► Se seleccionará el tipo de archivo para reporte que se desee, y luego se presionará el botón “Reporte”.�� 5T   k   5V      5W      �� 5X      $��0��6   $��9��6$   $��Center=�61   $=��7/FEI;component/images/ayuda_reporteFE_VentanaSelect.png��6N   $
��None=�6�   �� 5Y      $��0��6   $��10��6$   .��5Z      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   XVA continuación se mostrará la siguiente ventana emergente, la cual se ha de aceptar:5\      5]      �� 5^      $��0��6   $��11��6$   $��Center=�62   $C��=/FEI;component/images/ayuda_reporteFE_VentanaConfirmacion.png��6O   $
��None=�6�   �� 5_      $��0��6   $��12��6$   .��5`      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   KISe ingresará a la ruta de almacenamiento de reportes (Ruta de archivos):5b      5c      �� 5d      $��0��6   $��13��6$   $��Center=�62   $;��5/FEI;component/images/ayuda_reporteFE_VentanaRuta.png��6O   $
��None=�6�   �� 5e      $��0��6   $��14��6$   .��5f      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��El encabezado de columnas tendrá la siguiente descripción: CÓDIGO DE RESUMEN DIARIO, NÚMERO DE TICKET, ESTADO SCC, ESTADO SUNAT, FECHA DE EMISIÓN, FECHA DE ENVÍO, COMENTARIO SUNAT.5h      5i      �� 5j      $��0��6   $��15��6$   �� 5l      $��0��6   $��17��6$   5n      5o      5p      