   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.ayuda	FEI.ayuda  5          FEI.ayuda.RDSunat   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.ayuda     5      $	��300��5      $	��300��6     N� Title$  RDSunat��5	       N� 
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
��Bold"�6S   $��14(�6o   +)ENVÍO A SUNAT Y CONSULTA DE TICKET DE RC5)      5*      �� 5,      $��0��6   $��1��6$   .��5-      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Ésta opción permite enviar el Resumen Diario a SUNAT; con lo cual se obtendrá un número de Ticket; y posterior a ello se ha de consultar el estado del Ticket ante SUNAT.5/      50      �� 51      $��0��6   $��2��6$   $��Center=�61   $-��'/FEI;component/images/ayuda_RDSunat.png��6N   $
��None=�6   �� 52      $��0��6   $��3��6$   .��54      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Antes de enviar un Resumen Diario a SUNAT, se podrá verificar cuáles son los documentos que están incluidos en cada Resumen Diario.�� 55   �   ��Para ello, deberá de seleccionar la fila del Resumen Diario que desea consultar, tal cual se muestra en la imagen en el PASO 1.�� 56   �   ��Luego en la parte inferior en “Detalle Resumen”, se mostrará el detalle de todos los documentos incluidos, tal cual se muestra en la imagen en el PASO 2.�� 57   �   59      5:      �� 5;      $��0��6   $��4��6$   $��Center=�61   $5��//FEI;component/images/ayuda_RDSunat_Ventana.png��6N   $
��Fill=�6�   �� 5<      $��0��6   $��5��6$   .��5>      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5?      .�6   !OPCIÓN LIBERAR (PASO OPCIONAL)69   �� 6?   ��La opción “LIBERAR” permite liberar, sacar, extraer todos los documentos ingresado en el Resumen Diario seleccionado, con el fin de que sean agregados a un NUEVO Resumen Diario.�� 5@   �   ��En caso exista algún error (No se consideró algún documento, o se está ingresando uno que antes tiene que ser corregido, u otra incidencia), entonces para éste tipo de situaciones se ha previsto utilizar la opción “LIBERAR”.�� 5A   �   �� 5B      .�6   ENVIAR A SUNAT (PASO 3)6    �� 6&   TRLa opción “ENVIAR A SUNAT” permite enviar el Resumen Diario generado a SUNAT.5D      5E      �� 5F      $��0��6   $��7��6$   $��Center=�61   $9��3/FEI;component/images/ayuda_RDSunat_Ventana_Dos.png��6N   $
��Fill=�6�   �� 5G      $��0��6   $��8��6$   .��5H      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Luego de presionar el botón “Enviar a SUNAT”, se mostrará la siguiente ventana, que indica que el documento está siendo procesado para enviar a SUNAT.5J      5K      �� 5L      $��0��6   $��9��6$   $��Center=�61   $5��//FEI;component/images/ayuda_FEVentana_Carga.png��6N   $
��None=�6�   �� 5M      $��0��6   $��10��6$   .��5N      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   QOUna vez enviado a SUNAT se mostrará el siguiente mensaje: DOCUMENTOS ENVIADOS.5P      5Q      �� 5R      $��0��6   $��11��6$   $��Center=�62   $B��</FEI;component/images/ayuda_RDSunat_Ventana_Confirmacion.png��6O   $
��None=�6�   �� 5S      $��0��6   $��12��6$   .��5T      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   mkHaciendo clic en “Ver Detalles”, se mostrarán cuáles son los Resúmenes que han sido enviados a SUNAT5V      5W      �� 5X      $��0��6   $��13��6$   $��Center=�62   $J��D/FEI;component/images/ayuda_RDSunat_Ventana_ConfirmacionDetalles.png��6O   $
��None=�6�   �� 5Y      $��0��6   $��14��6$   .��5Z      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   �� 5[      .�6   
RECORDAR6!   �� : Una vez realizado el envío de Resumen Diario, SUNAT devolverá un número de Ticket con el fin que el Resumen Diario sea consultado ante SUNAT para ver el estado del mismo.�� 6�   ��Por lo tanto continuación se seguirá con el siguiente paso; se tendrá que consultar el número de TICKET que devolvió SUNAT.�� 5\   �   �� 6�   �� 5]      .�6   CONSULTAR TICKET (PASO 4)6"   �� 6(   �La opción “CONSULTAR TICKET”, es el último paso que se deberá realizar para completar el envío de “Resumen Diario”.�� 5^   u   ��Se deberá de seleccionar el Resumen Diario que se desea consultar por número de Ticket, y luego se presionará el botón “Consulta Ticket”.�� 5_   �   5a      5b      �� 5c      $��0��6   $��15��6$   $��Center=�62   $<��6/FEI;component/images/ayuda_RDSunat_Ventana_Ticket.png��6O   $
��Fill=�6�   �� 5f      $��0��6   $��16��6$   .��5g      �� $
��Wrap=�6   $ Justify=�60   $��11(�6H   $��Calibri)�6`   ��Para poder visualizar la Factura electrónica enviada, se deberá de ingresar al “Reporte de Facturas Electrónicas”, ahí es donde se visualizará si el comprobante ha sido “ACEPTADO” o “RECHAZADO por SUNAT.5i      5j      �� 5k      $��0��6   $��17��6$   $��Center=�62   $7��1/FEI;component/images/ayuda_FEVentana_Reporte.png��6O   $
��Fill=�6�   5m      5n      5o      