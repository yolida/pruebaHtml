   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.ReporteRD   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� Title$  	ReporteRD��5	       N� 
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
��Bold"�6S   $��14(�6o   REPORTE DE RESUMEN DIARIO5)      5*      �� 5,      $��0��6   $��1��6$   .��5-      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Ésta opción me permitirá visualizar un reporte de todos los Resúmenes Diarios generados (Resumen que contiene boletas electrónicas, notas de crédito electrónicas y notas de débito electrónicas asociadas).5/      50      �� 51      $��0��6   $��2��6$   $��Center=�61   $/��)/FEI;component/images/ayuda_reporteRD.png��6N   $
��None=�6�   �� 52      $��0��6   $��3��6$   .��54      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Previo a la generación del reporte deseado, se podrá realizar una búsqueda de los Resúmenes Diarios,a través de los filtros que considere.�� 55   �   jhSe tiene la posibilidad de filtrar por: Estado de comprobante en SUNAT, Fecha de Inicio, y Fecha de Fin.57      58      �� 59      $��0��6   $��4��6$   $��Center=�61   $7��1/FEI;component/images/ayuda_reporteRD_Ventana.png��6N   $
��Fill=�6�   �� 5:      $��0��6   $��5��6$   .��5<      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   SQLos “Estados de comprobante en SUNAT” para Resumen Diario son los siguientes:�� 5=   \   ► �� 5>      .�6	   
ACEPTADO6   `^: El Resumen Diario cumple con las validaciones establecidas, por tanto es aceptado por SUNAT.�� 6w   ► �� 5?      .�6	   	RECHAZADO6   ��:El Resumen Diario no cumple con las validaciones establecidas, por tanto se deberá de generar un nuevo Resumen Diario con correlativo siguiente. En este caso, ninguno de los comprobantes de pago electrónicos que hubieran estado incluidos en el Resumen Diario Rechazado, no tendrían validez tributaria.�� 6H  ► �� 5@      .�6	   
SIN ESTADO6   �~: El Resumen Diario aún no es validado por SUNAT, ya sea por error en la red del cliente, o por error en la webservice SUNAT.�� 6�   5B      5C      �� 5D      $��0��6   $��6��6$   .��5E      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5F      .�6   Detalle de Resumen Diario62   �� 69   }En el Reporte de Resumen Diario, se podrá visualizar cuáles son los documentos que están incluidos en cada Resumen Diario.�� 5G   �   ��Para poder saber cuáles son los documentos que están incluidos en cada Resumen Diario, deberá de seleccionar la fila del Resumen Diario que desea consultar, tal cual se muestra en la imagen en el PASO 1.�� 5H   �   ��Luego en la parte inferior en “Detalle de Comunicación de Baja”, se mostrará el detalle de todos los documentos incluidos, tal cual se muestra en la imagen en el PASO 2.�� 5I   �   5J      5K      �� 5L      $��0��6   $��7��6$   $��Center=�61   $;��5/FEI;component/images/ayuda_reporteRD_VentanaOtro.png��6N   $
��Fill=�6�   �� 5M      $��0��6   $��8��6$   .��5N      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5O      .�6   ,*Reporte en Excel y/o PDF de RESUMEN DIARIO6C   �� 6I   DBPasos para realizar la generación de una reporte en PDF o en CSV:�� 5P   C   ZX► En la parte inferior derecha, se muestra la opción de “Generación de Reporte”.�� 5Q   R   tr► Se seleccionará el tipo de archivo para reporte que se desee, y luego se presionará el botón “Reporte”.�� 5R   k   5T      5U      �� 5V      $��0��6   $��9��6$   $��Center=�61   $=��7/FEI;component/images/ayuda_reporteFE_VentanaSelect.png��6N   $
��None=�6�   �� 5W      $��0��6   $��10��6$   .��5X      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   XVA continuación se mostrará la siguiente ventana emergente, la cual se ha de aceptar:5Z      5[      �� 5\      $��0��6   $��11��6$   $��Center=�62   $C��=/FEI;component/images/ayuda_reporteFE_VentanaConfirmacion.png��6O   $
��None=�6�   �� 5]      $��0��6   $��12��6$   .��5^      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   KISe ingresará a la ruta de almacenamiento de reportes (Ruta de archivos):5`      5a      �� 5b      $��0��6   $��13��6$   $��Center=�62   $;��5/FEI;component/images/ayuda_reporteFE_VentanaRuta.png��6O   $
��None=�6�   �� 5c      $��0��6   $��14��6$   .��5d      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��El encabezado de columnas tendrá la siguiente descripción: CÓDIGO DE RESUMEN DIARIO, NÚMERO DE TICKET, ESTADO SCC, ESTADO SUNAT, FECHA DE EMISIÓN, FECHA DE ENVÍO, COMENTARIO SUNAT.5f      5g      �� 5h      $��0��6   $��15��6$   .��5i      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5j      .�6   REPORTE PDF6    (& , se mostrará de la siguiente forma:5k      5l      �� 5m      $��0��6   $��16��6$   $��Center=�62   $:��4/FEI;component/images/ayuda_reporteRD_VentanaPDF.png��6O   $
��Fill=�6�   �� 5o      $��0��6   $��17��6$   .��5p      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5q      .�6   REPORTE CSV6    (& , se mostrará de la siguiente forma:5r      5s      �� 5t      $��0��6   $��18��6$   $��Center=�62   $:��4/FEI;component/images/ayuda_reporteRD_VentanaCSV.png��6O   $
��Fill=�6�   5v      5w      5x      