   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.pages	FEI.pages  5      &     FEI.pages.ComunicacionBaja_Sunat   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.pages     5      -   5          N� Title$  Comunicacion Baja Sunat��5       � 	Resources 5
         MyContextMenu  BaseButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName��%^  &	        &	 �     �� 5   
   .@�5      m� -   5        $��Motivo de Baja��5      6/   m� 5      -   5        $��	Descartar��5      6*   5      �� 5   
   " ��6(   .�5      ��  �@�FocusVisualStyle 61   Z� �� 5       � �� �#1ba1e26+   �� 5       � �� �#1684ba6,   �� 5       � ��$ 1q�60   �� 5       � �� �#0000006+   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 	16,3,16,3q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��Chrome��6!   #��z��5    !   #��z��5!   !   #��z��5"   !    . ._�5$      �� $��	Presenter��6/   #��z��6@   #��z��5%   %   #��z��5&   %   ��. # z 5(   %   5)       5*      P� 5+       � {�	 .  . �5,   "   ��  � �� �#3333336?   5-      P� 5.       �@J�IsMouseOver	 . . �5/   "   ��  � �� �#dddddd6?   �� 50   "    � �� �#cccccc6@   �� 51   "    � �� �#3333336?   52      P� 53       � ��	 . . �54   "   ��  � �� �#1ba1e26?   �� 55   "    � �� �#1ba1e26@   �� 56   "    � �� �#ffffff6?   57      P� 58       �@J�	IsFocused	 . . �59   "   �� $
 Chrome��6)    � �� �#1ba1e26T   5:      5<      5>      5?      5@      .��5A      � 
������� � RowDefinitions 5B   
   �� 5C      $
��Auto �6   �� 5D      $��* �6    � ColumnDefinitions 5F   
   �� 5G      $��* �6   .+�5I   
   �� -   5         ��Name$ label��5I   -   $��0��6   $��0��6    $ ��COMUNICACION DE BAJA SUNAT��6<   $��Center=�6a   $��14(�6�   $
��Bold"�6�   $��Calibri)�6�   ���#dbeaf96�   �� 5J   
   $��0��6   $��1��6!   $��10,10,10,10q�6.   ���#DBDBDB �� CornerRadius$ 0��5L      $��
1, 1, 1, 1q�6    ._�5N      �  5O      �� 5P      $
��Auto �6$   �� 5Q      $
��Auto �6$   �� 5R      $��* �6$   �� 5S      $
��Auto �6$   �� 5T      $��* �6$   �� 5U      $
��Auto �6$    5W      �� 5X      $��* �6'   .+�5Z      � $��0��6   $��1��6(   $��
40,10,40,0q�65    5[      �� 5\      $
��Auto �6(   �� 5]      $
��Auto �6(    5_      �� 5`      $��5* �6+   �� 5a      $��4* �6+   �� 5b      $��4* �6+   �� 5c      $��4* �6+   .+�5e      �� $��0��6   $��0��6-   $��Fecha de Inicio��6:   $
��Left=�6T   $��Center=�6p   �� 5f      $��0��6   $��1��6-   $��Fecha de Fin��6:   $
��Left=�6Q   $��Center=�6m      FEI.pages.DatePickerEx  5g      -   5          Name$ datePick_inicio��5g   )   $��1��6B   $��0��6R   $��0,5,5,5q�6_   (  "System.Windows.Controls.DatePicker   IsDropDownOpen .     IsTodayHighlighted . 6�     5h      -   5        $ datePick_fin��5h   )   $��1��6?   $��1��6O   $��0,5,5,5q�6\    .   . 6�   �� 5i      $��2��6"   $��0��62   $��2��6?   $��2��6S   $��Right=�6d   $��Center=�6�   .+�5j      �� -   5        $��80��5j   !   $��Right=�6,   $��0,0,0,0q�6H   .��5k      ��  �� Orientation$ 
Horizontal=�6)   .+�5l   "   �� -   5         ��Name$ imageButton��5l   (   $+��%/FEI;component/images/search-icon.png��6=   $
��Fill=�6l   $��15��6{   $��15��6�   �� 5m   "   $��Filtrar��6(   5n      5o      5p      5q      &   System.Windows.Controls.DataGrid  5r      -	   5          Name$ dgComprobantesBaja��5r   c   $��0��6   $��2��6+   $��
40,10,40,0q�68      FrozenColumnCount$ 0��6L     HeaderStyle   ColumnHeaderStyle# �  6      AutoGenerateColumns .     CanUserAddRows .     SelectionMode$ Single=�5u         CanUserDeleteRows .     CanUserResizeRows .  
�������   HeadersVisibility$ Column=�5y         VerticalGridLinesBrush �#000000   GridLinesVisibility$
 None=�5{         SelectionUnit$ FullRow=�6.   $	��350��6G   $	��100��6W    5}        �� Color��%�   (��       5~   *   * SystemColors.HighlightBrushKey+)(�� !     5   *   *$"SystemColors.HighlightTextBrushKey+)�� 5~      $  #DEDCD9��6\   �� 5      $  Black��6`   5�      !   Columns! 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      ,  &System.Windows.Controls.DataGridColumn"   MaxWidth$" 35Q�61   #   CanUserReorder# .  $   CanUserResize$ .  %   CellTemplate% 5�      �� 5�   "   .R�5�   &   �� $��chkDiscontinue��6/   -
   5        $��0 2 0 0q�5�   s   & d� 	IsChecked& 6F   �� ' �� Path$' Check�( �� Mode$( TwoWay=�6�   5�   #   )   	CellStyle) 5�      �� 5�   "   *  $System.Windows.Controls.DataGridCell"  6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   5�   #   5�      0  *System.Windows.Controls.DataGridTextColumn  5�      *   
IsReadOnly* . +   MinWidth$	+ 150Q�6`   # .  ,   Width5  /System.Windows.Controls.DataGridLengthConverter$, * 6�   1	  +System.Windows.Controls.DataGridBoundColumn- 	  Binding- 6-   �� *FechaEmision+.   Header. 5�      �� 5�   "   $$��Fecha de emisión comprobantes��6-   $��Center=�6R   $��Center=�6m   $
��Wrap=�6�   / �� TextAlignment$/ Center=�6�   0 	  ElementStyle0 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   5�   #   5�        5�      * . $+ 90Q�6[   # .  1   SortDirection$1 	AscendingX�6�   2   CanUserSort2 . $, * 6�   - 6-   �� *	Archivo+. 5�      �� 5�   "   $��Archivo��6-   $��Center=�6<   $��Center=�6W   0 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   5�   #   5�        5�      * . $+ 90Q�6Z   # .  $1 	AscendingX�6�   2 . $, * 6�   - 6-   �� *Ticket+. 5�      �� 5�   "   $��Nro de Ticket��6-   $��Center=�6B   $��Center=�6]   0 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   5�   #   5�        5�      * . $+ 80Q�6_   # .  $1 	AscendingX�6�   2 . $, * 6�   - 6-   �� *EstadoSunat+. 5�      �� 5�   "   $��Estado SUNAT��6-   $��Center=�6A   $��Center=�6\   0 5�      �� 5�   "   " ��6(   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   �� 5�   &    � ��$
 Wrap=�6O   3 �� Triggers3 5�   &   P� 5�   *    � ��$	 ACEPTADO��6B   . �5�   .   ��  � ��
 � � �6K   5�   +   P� 5�   *    � ��$	 	RECHAZADO��6B   . �5�   .   ��  � ��
 �**��6K   5�   +   P� 5�   *    � ��$	 SIN RESPUESTA��6B   . �5�   .   ��  � ��
 �  ��6K   5�   +   P� 5�   *    � ��$	 DE BAJA��6B   . �5�   .   ��  � ��
 �r���6K   5�   +   5�   #   5�        5�      * . $	+ 100Q�6^   # .  $1 	AscendingX�6�   2 . $, * 6�   - 6-   �� *
FechaEnvio+. 5�      �� 5�   "   $��Fecha de Envío��6-   $��Center=�6C   $��Center=�6^   0 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   5�   #   5�        5�      $	+ 200Q�6L   $, 2* 6[   * . 2 .  # .  $ .  - 6-   �� *
Comentario+. 5�      �� 5�   "   $��
Comentario��6-   $��Center=�6?   $��Center=�6Z   0 5�      �� 5�   "   .�5�   &   ��  � ��$
 Wrap=�6O   �� 5�   &    �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   �� 5�   &    � ��$ 9(�6K   5�   #   5�      5�      �� 5�      -   5        $ Detalle��5�   \   $��Calibri)�6   $��0,10,0,0q�6-   $��0��6?   $��3��6O   $#��Detalle Comunicación de Baja��6m   $��Center=�6�   $��Center=�6�   $��13(�6�   $
��Bold"�6�     5�      -   5        $ dgComprobantes��5�   b   $��0��6   $��4��6+   $��	40,5,40,0q�68   $ 0��6K   # �  6z   $��Center=�6�    .   .  $ Single=�5�       .   .  $ Column=�5�       �#000000$
 None=�5�      $ FullRow=�6.   $	��200��6G   $��80��6W   
�������4 � ContextMenu#4 [  6y    5�      ��%�   (��       5�   *   * SystemColors.HighlightBrushKey+)(�� !     5�   *   *$"SystemColors.HighlightTextBrushKey+)�� 5�      $  #DEDCD9��6\   �� 5�      $  Black��6`   5�      ! 5�        5�      * . $	+ 150Q�6]   $, 3* 6l   # .  - 6-   �� *	TipoTexto+. 5�      �� 5�   "   $��Comprobante��6-   $��Center=�6@   $��Center=�6[   0 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   5�   #   5       5     * . $+ 50Q�6X   $, * 6g   # .  $1 	AscendingX�6�   2 . - 6-   �� *Tipo+. 5     �� 5  "   $��Código��6-   $��Center=�6;   $��Center=�6V   0 5     �� 5  "   .�5  &   ��  �@��TextAlignment$
 Left=�6P   �� 5	  &    � ��$ Center=�6T   5
  #   5       5     * . $+ 70Q�6]   $, 2* 6k   # .  $1 	AscendingX�6�   2 . - 6-   �� *	EstadoSCC+. 5     �� 5  "   $��
Estado SCC��6-   $��Center=�6?   $��Center=�6Z   0 5     �� 5  "   " ��6(   .�5  &   ��  �@��TextAlignment$
 Left=�6P   �� 5  &    � ��$ Center=�6T   �� 5  &    � ��$
 Wrap=�6O   3 5  &   P� 5  *    � ��$	 ENVIADO��6B   . �5  .   ��  � ��
 � � �6K   5  +   P� 5  *    � ��$	 PENDIENTE (CORRECTO)��6B   . �5  .   ��  � ��
 ��iA�6K   5  +   P� 5  *    � ��$	 PENDIENTE (ERRORES)��6B   . �5   .   ��  � ��
 �  ��6K   5"  +   5$  #   5&       5'     * . $+ 80Q�6_   $, 2* 6m   # .  $1 	AscendingX�6�   2 . - 6-   �� *EstadoSunat+. 5(     �� 5)  "   $��Estado Sunat��6-   $��Center=�6A   $��Center=�6\   0 5+     �� 5,  "   " ��6(   .�5-  &   ��  �@��TextAlignment$
 Left=�6P   �� 5.  &    � ��$ Center=�6T   �� 5/  &    � ��$
 Wrap=�6O   3 50  &   P� 51  *    � ��$	 ACEPTADO��6B   . �52  .   ��  � ��
 � � �6K   54  +   P� 55  *    � ��$	 	RECHAZADO��6B   . �56  .   ��  � ��
 �**��6K   58  +   P� 59  *    � ��$	 SIN RESPUESTA��6B   . �5:  .   ��  � ��
 �  ��6K   5<  +   5B  #   5D       5E     * . $	+ 100Q�6_   $, 2* 6n   # .  $1 	AscendingX�6�   2 . - 6-   �� *SerieNumero+. 5F     �� 5G  "   $��Serie-Número��6-   $��Center=�6A   $��Center=�6\   0 5I     �� 5J  "   .�5K  &   ��  �@��TextAlignment$
 Left=�6P   �� 5L  &    � ��$ Center=�6T   5M  #   5O       5P     * . $	+ 100Q�6b   $, 2* 6q   # .  $1 	AscendingX�6�   2 . - 6/   �� *FechaEmision+. 5Q     �� 5R  "   $��Fecha de emisión��6-   $��Center=�6E   $��Center=�6`   0 5T     �� 5U  "   .�5V  &   ��  �@��TextAlignment$
 Left=�6P   �� 5W  &    � ��$ Center=�6T   5X  #   5Z       5[     * . $	+ 100Q�6x   $, 2* 6�   # .  2 .  - 6/   �� *ComunicacionBajaMotivo+$( TwoWay=�. 5\     �� 5]  "   $��Motivo de Baja��6-   $��Center=�6C   $��Center=�6^   0 5_     �� 5`  "   .�5a  &   ��  �@��TextAlignment$
 Left=�6P   �� 5b  &    � ��$ Center=�6T   5c  #   5e     5g     � 5h     $��0��6   $��5��6(   $��40,20,40,20q�65    5i     �� 5j     $
��Auto �6(    5l     �� 5m     $��* �6+   �� 5n     $��2* �6+   .+�5p     ]� $��0��6    $��0��60   $
��Left=�6=   .+�5q     �� -   5        5 ��Name$5 btnDescartar��5q  3   $��0,0,20,0q�6!   $
��Left=�6I   $��Bottom=�6�   .��5r     �� $ 
Horizontal=�6)   .+�5s  "   �� -   5        $ imageDescartar��5s  (   $+��%/FEI;component/images/remove-icon.png��6@   $��18��6o   $��26��6{   �� 5t  "   -   5        $ TextBotonDescartar��5t  (   $��	Descartar��6D   5u     5v     5w     ]� 5x     $��1��6    $��0��60   $��Right=�6=   .+�5y     �� -   5        $5 btnRefrescar��5y  3   $��0,0,20,0q�6!   $��Right=�6I   $��Bottom=�6�   .��5z     �� $ 
Horizontal=�6)   .+�5{  "   �� -   5        $ imageRefrescar��5{  (   $'��!/FEI;component/images/refresh.png��6@   $��18��6k   $��26��6w   �� 5|  "   -   5        $ TextBotonRefrescar��5|  (   $��	Refrescar��6D   5}     5~     �� 5     -   5        $5 	btnTicket��5  3   $��0,0,20,0q�6!   $��Right=�6F   $��Bottom=�6{   .��5�     �� $ 
Horizontal=�6)   .+�5�  "   �� -   5        $ image��5�  (   $$��/FEI;component/images/send.png��67   $��18��6_   $��26��6k   �� 5�  "   -   5        $ 	TextBoton��5�  (   $��Consulta Ticket��6;   5�     5�     �� 5�     -   5        $5 btnSunat��5�  2   $��0,0,0,0q�6!   $��Right=�6D   $��Bottom=�6x   .��5�     �� $ 
Horizontal=�6)   .+�5�  "   �� -   5        $ 
imageSunat��5�  (   $$��/FEI;component/images/send.png��6<   $��18��6d   $��26��6p   �� 5�  "   -   5        $ TextBotonSunat��5�  (   $��Enviar a Sunat��6@   5�     5�     5�     5�     5�     5�     5�     5�     