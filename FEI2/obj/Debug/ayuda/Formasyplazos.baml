   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.Formasyplazos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� Title$  Formasyplazos��5	       N� 
Background
 �����.��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6    $��Center=�6-   .��5      �� $
��Wrap=�6    �� TextAlignment$ Center=�6-   $
��Bold"�6O   $��14(�6k   IGFORMAS Y PLAZOS PARA GENERACIÓN Y ENVÍO DE COMPROBANTES ELECTRÓNICOS5      5      �� 5   
   $��0��6   $��1��6    .��5      �� $
��Wrap=�6   $
��Bold"�6,   $
 Left=�6H   $��11(�6]   $��Calibri)�6u   1/Plazo de envío para Facturas y Notas asociadas5!      5"      �� 5#   
   $��0��6   $��2��6    .��5$      �� $
��Wrap=�6   $ Justify=�6,   $��11(�6D   $��Calibri)�6\   ��El plazo es de hasta 7 días calendarios contados a partir del día de emisión para hacer el envío, en la forma establecida en el anexo 6 de la R. de S. N° 097-2012/SUNAT. Ref: Art. 12° de la R. de S. N° 097-2012/2012, sustituido por el Art. 1° de la R. de S. N° 374-2013.5&      5'      �� 5(   
   $��0��6   $��3��6    .��5)      �� $
��Wrap=�6   $
��Bold"�6,   $
 Left=�6H   $��11(�6]   $��Calibri)�6u   Envío Sincróno5+      5,      �� 5-   
   $��0��6   $��4��6    .��5.      �� $
��Wrap=�6   $ Justify=�6,   $��11(�6D   $��Calibri)�6\   ��Los envío síncronos se realizarán para los comprobantes Facturas Electrónicas, Notas de Crédito Electrónicas, y Notas de Débito Electrónicas. El envío síncrono consiste en realizar un único envío a SUNAT, envío por cada documento obteniendo un CDR por cada uno.�� 50      �� 51      .�6   .�6   �� .�6   64→ Plazo de envío para Facturas y Notas asociadas:6R   6[   �� 6c   ��El plazo es de hasta 7 días calendarios contados a partir del día de emisión para hacer el envío, en la forma establecida en el anexo 6 de la R. de S. N° 097-2012/SUNAT. Ref: Art. 12° de la R. de S. N° 097-2012/2012, sustituido por el Art. 1° de la R. de S. N° 374-2013.�� 52   (  53      54      �� 55   
   $��0��6   $��5��6    .��56      �� $
��Wrap=�6   $
��Bold"�6,   $
 Left=�6H   $��11(�6]   $��Calibri)�6u   Envío Asincróno58      59      �� 5:   
   $��0��6   $��6��6    .��5;      �� $
��Wrap=�6   $ Justify=�6,   $��11(�6D   $��Calibri)�6\   ��El envío Asíncrono se realizará en los envíos de Resumen Diario, y Comunicación de Baja. El envío asíncrono consiste en realizar un primer envío a SUNAT y esperar que SUNAT luego envíe un número de Ticket para poder consultar el estado, obteniendo un CDR.�� 5<     �� 5=      .�6   .�6   �� .�6#   *(→ Plazo de envío para Resumen Diario:6N   6W   �� 6_   ��El plazo de envío es de 7 días calendarios, contados desde el día de emisión para hacer el envío. Por trartarse de una Declaración Jurada, entonces las declaraciones enviadas dentro del plazo del 7 días o posterior a ello, se considerarán como declaraciones sustitutorias o rectificatorias según corresponda.�� 5>   I  �� 5?      .�6   .�6   �� .�6"   /-→ Plazo de envío de Comunicación de Baja:6O   6X   �� 6`   *(Para baja de Facturas y Notas asociadas:�� 5@   =   �� El plazo es de hasta 7 días calendarios, contados desde el día siguiente de haber recibido la CDR-Factura y nota con estado aceptada.�� 5A   �   !Para Boletas y Notas asociadas:�� 5B   !   �� Si las boletas de venta no han sido informadas, el plazo para comunicarlas de baja es 7 días calendario contados a partir del día siguiente de su generación.�� 5C   �   �� Si las boletas de venta han sido informadas, el plazo para comunicarlas de baja es de 7 días calendario contados a partir del día siguiente de la fecha de recibida la CDR- Constancia de Recepción – ACEPTADA, del Resumen Diario correspondiente.�� 5D   �   5F      5G      5H      5I      