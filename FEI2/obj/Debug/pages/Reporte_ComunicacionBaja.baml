   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.pages	FEI.pages  5      (    "FEI.pages.Reporte_ComunicacionBaja   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.pages     5      -   5          N� Title$$  Reporte Comunicaciones de Baja��5       � 	Resources 5	         MyContextMenu  BaseButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName��%8  &	        &	 m     �� 5
   
   $��3q�6-   .@�5      m� -   5        $��Detalle del documento��5      66   5      �� 5   
   " ��6(   .�5      ��  �@�FocusVisualStyle 61   Z� �� 5       � �� �#1ba1e26+   �� 5       � �� �#1684ba6,   �� 5       � ��$ 1q�60   �� 5       � �� �#0000006+   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 	16,3,16,3q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��Chrome��6!   #��z��5   !   #��z��5   !   #��z��5   !    . ._�5       �� $��	Presenter��6/   #��z��6@   #��z��5!   %   #��z��5"   %   ��. # z 5$   %   5%       5&      P� 5'       � {�	 .  . �5(   "   ��  � �� �#3333336?   5)      P� 5*       �@J�IsMouseOver	 . . �5+   "   ��  � �� �#dddddd6?   �� 5,   "    � �� �#cccccc6@   �� 5-   "    � �� �#3333336?   5.      P� 5/       � ��	 . . �50   "   ��  � �� �#1ba1e26?   �� 51   "    � �� �#1ba1e26@   �� 52   "    � �� �#ffffff6?   53      P� 54       �@J�	IsFocused	 . . �55   "   �� $
 Chrome��6)    � �� �#1ba1e26T   56      58      5:      5;      5<      .��5=      � 
������� � RowDefinitions 5>   
   �� 5?      $
��Auto �6   �� 5@      $��* �6    � ColumnDefinitions 5B   
   �� 5C      $��* �6   .+�5E   
   �� -   5         ��Name$ label��5E   -   $��0��6   $��0��6    $%��REPORTE DE COMUNICACION DE BAJA��6<   $��Center=�6f   $��14(�6�   $
��Bold"�6�   $��Calibri)�6�   ���#dbeaf96�   �� 5F   
   $��0��6   $��1��6!   $��10,10,10,10q�6.   ���#DBDBDB �� CornerRadius$ 0��5H      $��
1, 1, 1, 1q�6    ._�5J      � $��0,0,0,0q�6    5K      �� 5L      $
��Auto �6$   �� 5M      $��* �6$   �� 5N      $
��Auto �6$   �� 5O      $��* �6$   �� 5P      $
��Auto �6$    5R      �� 5S      $��* �6'   .+�5U      � $��0��6   $��0��6(   $��
40,10,40,0q�65    5V      �� 5W      $
��Auto �6(   �� 5X      $
��Auto �6(    5Z      �� 5[      $��4* �6+   �� 5\      $��4* �6+   �� 5]      $��5* �6+   �� 5^      $��4* �6+   .+�5`      �� $��0��6   $��0��6-   $��Fecha de Inicio��6:   $
��Left=�6T   $��Center=�6p   �� 5a      $��0��6   $��1��6-   $��Fecha de Fin��6:   $
��Left=�6Q   $��Center=�6m      FEI.pages.DatePickerEx  5b      -   5          Name$ datePick_inicio��5b   )   $��1��6B   $��0��6R   $��0,5,5,5q�6_   (  "System.Windows.Controls.DatePicker   IsDropDownOpen .     IsTodayHighlighted . 6�     5c      -   5        $ datePick_fin��5c   )   $��1��6?   $��1��6O   $��0,5,5,5q�6\    .   . 6�   �� 5d      $��2��6   $��0��6-   $!��Estado de comprobante Sunat��6:   $
��Left=�6`   $��Center=�6|   �� 5e      -   5         ��Name$ cboEstadoSunat��5e       $��3��68   $��0��6H   $��0,5,5,5q�6U     ComboBoxFlatStyle#��[ 6f   �� 5f      $��2��6"   $��1��62   $��2��6?   $��Right=�6S   $��Center=�6o   .+�5g      �� -   5        $��80��5g   !   $��0,0,5,0q�6,   .��5h      ��  �� Orientation$ 
Horizontal=�6)   .+�5i   "   �� -   5         ��Name$ imageButton��5i   (   $+��%/FEI;component/images/search-icon.png��6=   $
��Fill=�6l   $��15��6{   $��15��6�   �� 5j   "   $��Filtrar��6(   5k      5l      5m      5n      &   System.Windows.Controls.DataGrid  5o      -	   5          Name$ dgComprobantesBaja��5o   c   $��0��6   $��1��6+   $��
40,10,40,0q�68      FrozenColumnCount$ 0��6L     HeaderStyle   ColumnHeaderStyle# �  6      AutoGenerateColumns .     CanUserAddRows .     SelectionMode$ Single=�5r         CanUserDeleteRows .     CanUserResizeRows .  
�������   HeadersVisibility$ Column=�5v         VerticalGridLinesBrush �#000000   GridLinesVisibility$
 None=�5x          SelectionUnit$  FullRow=�6.   $	��350��6G   $	��100��6W    5y      ! �� Color��%�   (��       5z   *   * SystemColors.HighlightBrushKey+)(�� !     5{   *   *$"SystemColors.HighlightTextBrushKey+)�� 5z      $! #DEDCD9��6\   �� 5{      $! Black��6`   5|      "   Columns" 5}      0  *System.Windows.Controls.DataGridTextColumn  5~      ,  &System.Windows.Controls.DataGridColumn#   
IsReadOnly# . $   MinWidth$	$ 150Q�6`   %   CanUserReorder% .  &   Width5  /System.Windows.Controls.DataGridLengthConverter$& * 6�   1  +System.Windows.Controls.DataGridBoundColumn'   Binding' 6-   �� *FechaEmision+(   Header( 5      �� 5�   "   $$��Fecha de emisión comprobantes��6-   ) �� TextAlignment$) Center=�6R   $��Center=�6i   $��Center=�6�   $
��Wrap=�6�   *   ElementStyle* 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   �� 5�   &    � ��$
 Wrap=�6O   5�   #   5�        5�      # . $$ 90Q�6[   % .  +   SortDirection$+ 	AscendingX�6�   ,   CanUserSort, . $& * 6�   ' 6-   �� *	Archivo+( 5�      �� 5�   "   $��Archivo��6-   $��Center=�6<   $��Center=�6W   * 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   �� 5�   &    � ��$
 Wrap=�6O   5�   #   5�        5�      # . $$ 90Q�6Z   % .  $+ 	AscendingX�6�   , . $& * 6�   ' 6-   �� *Ticket+( 5�      �� 5�   "   $��Nro de Ticket��6-   $��Center=�6B   $��Center=�6]   * 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$
 Wrap=�6O   �� 5�   &    � ��$ Center=�6T   5�   #   5�        5�      # . $$ 80Q�6_   % .  $+ 	AscendingX�6�   , . $& * 6�   ' 6-   �� *EstadoSunat+( 5�      �� 5�   "   $��Estado SUNAT��6-   $��Center=�6A   $��Center=�6\   * 5�      �� 5�   "   " ��6(   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   �� 5�   &    � ��$
 Wrap=�6O   - �� Triggers- 5�   &   P� 5�   *    � ��$	 ACEPTADO��6B   . �5�   .   ��  � ��
 � � �6K   5�   +   P� 5�   *    � ��$	 	RECHAZADO��6B   . �5�   .   ��  � ��
 �**��6K   5�   +   P� 5�   *    � ��$	 SIN RESPUESTA��6B   . �5�   .   ��  � ��
 �  ��6K   5�   +   P� 5�   *    � ��$	 DE BAJA��6B   . �5�   .   ��  � ��
 �r���6K   5�   +   5�   #   5�        5�      # . $	$ 100Q�6^   % .  $+ 	AscendingX�6�   , . $& * 6�   ' 6-   �� *
FechaEnvio+( 5�      �� 5�   "   $��Fecha de Envío��6-   $��Center=�6C   $��Center=�6^   * 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   �� 5�   &    � ��$
 Wrap=�6O   5�   #   5�        5�      $	$ 200Q�6M   $& 2* 6\   # . , .  % .  .   CanUserResize. .  ' 6-   �� *
Comentario+( 5�      �� 5�   "   $��
Comentario��6-   $��Center=�6?   $��Center=�6Z   * 5�      �� 5�   "   .�5�   &   ��  � ��$
 Wrap=�6O   �� 5�   &    �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   �� 5�   &    � ��$ 9(�6K   5�   #   5�      5�      �� 5�      -
   5        $ Detalle��5�   G   $��0,10,0,0q�6   $��0��6*   $��2��6:   $"��Detalle Comunicacion de Baja��6X   $��Center=�6   $��Center=�6�   $��11(�6�   $
��Bold"�6�   $��Times New Roman)�6�     5�      -   5        $ dgComprobantes��5�   b   $��0��6   $��3��6+   $��	40,5,40,0q�68   $ 0��6K   # �  6z   $��Center=�6�    .   .  $ Single=�5�       .   .  $ Column=�5�       �#000000$
 None=�5�      $  FullRow=�6.   $	��200��6G   $��80��6W   
�������/ � ContextMenu#/ [  6y    5�      ��%�   (��       5�   *   * SystemColors.HighlightBrushKey+)(�� !     5�   *   *$"SystemColors.HighlightTextBrushKey+)�� 5�      $! #DEDCD9��6\   �� 5�      $! Black��6`   5�      " 5�        5�      # . $	$ 150Q�6]   $& 3* 6l   % .  ' 6-   �� *	TipoTexto+( 5�      �� 5�   "   $��Comprobante��6-   $��Center=�6@   $��Center=�6[   * 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$
 Wrap=�6O   �� 5�   &    � ��$ Center=�6T   5�   #   5�        5�      # . $	$ 100Q�6_   $& 2* 6n   % .  $+ 	AscendingX�6�   , . ' 6-   �� *SerieNumero+( 5�      �� 5�   "   $��Serie-Número��6-   $��Center=�6A   $��Center=�6\   * 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$
 Wrap=�6O   �� 5�   &    � ��$ Center=�6T   5�   #   5       5     # . $$ 70Q�6]   $& 2* 6k   % .  $+ 	AscendingX�6�   , . ' 6-   �� *	EstadoSCC+( 5     �� 5  "   $��
Estado SCC��6-   $��Center=�6?   $��Center=�6Z   * 5     �� 5  "   " ��6(   .�5  &   ��  �@��TextAlignment$
 Left=�6P   �� 5  &    � ��$
 Wrap=�6O   �� 5  &    � ��$ Center=�6T   - 5  &   P� 5  *    � ��$	 ENVIADO��6B   . �5  .   ��  � ��
 � � �6K   5  +   P� 5  *    � ��$	 PENDIENTE (CORRECTO)��6B   . �5  .   ��  � ��
 ��iA�6K   5  +   P� 5   *    � ��$	 PENDIENTE (ERRORES)��6B   . �5!  .   ��  � ��
 �  ��6K   5#  +   5%  #   5'       5(     # . $$ 80Q�6_   $& 2* 6m   % .  $+ 	AscendingX�6�   , . ' 6-   �� *EstadoSunat+( 5)     �� 5*  "   $��Estado SUNAT��6-   $��Center=�6A   $��Center=�6\   * 5,     �� 5-  "   " ��6(   .�5.  &   ��  �@��TextAlignment$
 Left=�6P   �� 5/  &    � ��$
 Wrap=�6O   �� 50  &    � ��$ Center=�6T   - 51  &   P� 52  *    � ��$	 ACEPTADO��6B   . �53  .   ��  � ��
 � � �6K   55  +   P� 56  *    � ��$	 	RECHAZADO��6B   . �57  .   ��  � ��
 �**��6K   59  +   P� 5:  *    � ��$	 SIN RESPUESTA��6B   . �5;  .   ��  � ��
 �  ��6K   5=  +   P� 5>  *    � ��$	 DE BAJA��6B   . �5?  .   ��  � ��
 �r���6K   5A  +   5C  #   5E       5G     # . $	$ 100Q�6b   $& 2* 6q   % .  $+ 	AscendingX�6�   , . ' 6/   �� *FechaEmision+( 5H     �� 5I  "   $��Fecha de emisión��6-   $��Center=�6E   $��Center=�6`   * 5K     �� 5L  "   .�5M  &   ��  �@��TextAlignment$
 Left=�6P   �� 5N  &    � ��$
 Wrap=�6O   �� 5O  &    � ��$ Center=�6T   5P  #   5R     5T     � 5U     $��0��6   $��4��6(   $��
0,20,40,20q�65    5V     �� 5W     $
��Auto �6(    5Y     �� 5Z     $��3* �6+   �� 5[     $��3* �6+   �� 5\     $��3* �6+   �� 5]     $��3* �6+   �� 5^     $��3* �6+   �� 5_     $��3* �6+   .+�5d     ]� $��3��6"   $��3��62   $��0��6G   $��Right=�6U   .+�5e     �� -   5        $ cboDownload��5e  $   $	��100��69   $��Center=�6E   #��[ 6i   �� 5f     -   5        $��10,0,0,0q�5f  !   $��Right=�63   $��Center=�6h   .��5g     �� $ 
Horizontal=�6)   .+�5h  "   �� $,��&/FEI;component/images/download-png.png��6(   $��10,0,0,0q�6X   $��18��6k   $��20��6w   $
��Fill=�6�   �� 5i  "   $��Reporte��6(   5k     5l     �� 5m     -   5        $��10,0,0,0q�5m  !   $��Right=�63   $��Center=�6q   .��5n     �� $ 
Horizontal=�6)   .+�5o  "   �� $,��&/FEI;component/images/download-png.png��6(   $��10,0,0,0q�6X   $��18��6k   $��20��6w   $
��Fill=�6�   �� 5p  "   $��Reporte Detallado��6(   5r     5s     5t     5u     5v     5w     5x     5y     