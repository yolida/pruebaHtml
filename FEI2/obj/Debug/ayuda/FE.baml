   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.FE   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� 
Background
  ����� N� Title$ FE��5	      .��5      �� $��Visible=�6   .��5   
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
��Bold"�6S   $��14(�6o   ENVÍO A SUNAT DE FE5)      5*      �� 5,      $��0��6   $��1��6$   .��5-      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ~|Ésta opción permite enviar manualmente las Facturas Electrónicas y sus notas asociadas que aún se encuentren SIN ESTADO.�� 5.   �   ��En ésta opción sólo se visualizarán Facturas Electrónicas y notas asociadas que se encuentren SIN ESTADO, es decir sin haber sido enviadas aúna SUNAT.�� 5/   �   ��Las Facturas Electrónicas o notas asociadas se encontrarán SIN ESTADO, en caso se haya configurado para que se realice el envío de las mismas de forma manual, o en caso al momento del envío automático haya existido alguna falla de red, ya sea por parte de SUNAT o por parte de red de la propia empresa por tanto estos documentos no fueron enviados.�� 50   r  51      52      �� 53      $��0��6   $��2��6$   $��Center=�61   $(��"/FEI;component/images/ayuda_FE.png��6N   $
��None=�6z   �� 54      $��0��6   $��3��6$   .��56      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Se deberán de seleccionar las Facturas Electrónicas y notas asociadas que deseen enviarse a SUNAT y luego presionar el botón “Enviar”.58      59      �� 5:      $��0��6   $��4��6$   $��Center=�61   $/��)/FEI;component/images/ayuda_FEVentana.png��6N   $
��Fill=�6�   �� 5;      $��0��6   $��5��6$   .��5=      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5>      .�6   Nota6   ��Al realiza un envío masivo, es decir se selecciona todo un grupo de facturas electrónicas y notas asociadas, recordar que el envío de facturas electrónicas y notas asociadas es de uno a uno, comprobante por comprobante será enviado a SUNAT a pesar de haber seleccionado todo un grupo.5?      5@      �� 5A      $��0��6   $��6��6$   .��5B      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Luego de presionar el botón enviar se mostrará la siguiente ventana, que indica que el documento está siendo procesado para enviar a SUNAT.5D      5E      �� 5F      $��0��6   $��7��6$   $��Center=�61   $5��//FEI;component/images/ayuda_FEVentana_Carga.png��6N   $
��None=�6�   �� 5G      $��0��6   $��8��6$   .��5H      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   QOUna vez enviado a SUNAT se mostrará el siguiente mensaje: DOCUMENTOS ENVIADOS.5K      5L      �� 5M      $��0��6   $��9��6$   $��Center=�61   $<��6/FEI;component/images/ayuda_FEVentana_DocsEnviados.png��6N   $
��None=�6�   �� 5N      $��0��6   $��10��6$   .��5O      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   nlHaciendo clic en “Ver Detalles”, se mostrarán cuáles son los documentos que han sido enviados a SUNAT.5Q      5R      �� 5S      $��0��6   $��11��6$   $��Center=�62   $C��=/FEI;component/images/ayuda_FEVentana_DocsEnviadosDetalle.png��6O   $
��None=�6�   �� 5T      $��0��6   $��12��6$   .��5U      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   KISe ingresará a la ruta de almacenamiento de reportes (Ruta de archivos):5W      5X      �� 5Y      $��0��6   $��13��6$   $��Center=�62   $;��5/FEI;component/images/ayuda_reporteFE_VentanaRuta.png��6O   $
��None=�6�   �� 5Z      $��0��6   $��14��6$   .��5[      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��A continuación ya NO se mostrarán las Facturas Electrónicas y notas asociadas en la ventana de “Envío de Facturas Electrónicas”.5]      5^      �� 5_      $��0��6   $��15��6$   $��Center=�62   $6��0/FEI;component/images/ayuda_FEVentana_Blanco.png��6O   $
��Fill=�6�   �� 5b      $��0��6   $��16��6$   .��5c      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Para poder visualizar la Factura electrónica enviada, se deberá de ingresar al “Reporte de Facturas Electrónicas”, ahí es donde se visualizará si el comprobante ha sido “ACEPTADO” o “RECHAZADO por SUNAT.5e      5f      �� 5g      $��0��6   $��17��6$   $��Center=�62   $7��1/FEI;component/images/ayuda_FEVentana_Reporte.png��6O   $
��Fill=�6�   5i      5j      5k      