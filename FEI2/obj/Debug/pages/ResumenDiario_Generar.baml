   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.pages	FEI.pages  5      %    FEI.pages.ResumenDiario_Generar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.pages     5      -   5          N� Title$  Resumen Diario Generar��5       � 	Resources 5	         MyContextMenu  BaseButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName��%+  &	        &	 `     �� 5
   
   .@�5      m� -   5        $��Detalle del documento��5      66   5      �� 5   
   " ��6(   .�5      ��  �@�FocusVisualStyle 61   Z� �� 5       � �� �#1ba1e26+   �� 5       � �� �#1684ba6,   �� 5       � ��$ 1q�60   �� 5       � �� �#0000006+   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 	16,3,16,3q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��Chrome��6!   #��z��5   !   #��z��5   !   #��z��5   !    . ._�5       �� $��	Presenter��6/   #��z��6@   #��z��5!   %   #��z��5"   %   ��. # z 5$   %   5%       5&      P� 5'       � {�	 .  . �5(   "   ��  � �� �#3333336?   5)      P� 5*       �@J�IsMouseOver	 . . �5+   "   ��  � �� �#dddddd6?   �� 5,   "    � �� �#cccccc6@   �� 5-   "    � �� �#3333336?   5.      P� 5/       � ��	 . . �50   "   ��  � �� �#1ba1e26?   �� 51   "    � �� �#1ba1e26@   �� 52   "    � �� �#ffffff6?   53      P� 54       �@J�	IsFocused	 . . �55   "   �� $
 Chrome��6)    � �� �#1ba1e26T   56      58      5:      5;      5<      .��5=      � 
������� � RowDefinitions 5>   
   �� 5?      $
��Auto �6   �� 5@      $��* �6    � ColumnDefinitions 5B   
   �� 5C      $��* �6   .+�5E   
   �� -   5         ��Name$ label��5E   -   $��0��6   $��0��6    $��AGREGAR A RESUMEN DIARIO��6<   $��Center=�6_   $��14(�6�   $
��Bold"�6�   $��Calibri)�6�   ���#dbeaf96�   �� 5F   
   $��0��6   $��1��6!   $��10,10,10,10q�6.   ���#DBDBDB �� CornerRadius$ 0��5H      $��
1, 1, 1, 1q�6    ._�5J      � $��0,0,0,0q�6    5K      �� 5L      $
��Auto �6$   �� 5M      $
��Auto �6$   �� 5N      $
��Auto �6$   �� 5O      $
��Auto �6$    5Q      �� 5R      $��* �6'   .+�5T      � $��0��6   $��0��6(   $��
40,10,50,0q�65    5U      �� 5V      $
��Auto �6(   �� 5W      $
��Auto �6(    5Y      �� 5[      $��5* �6+   �� 5\      $��4* �6+   �� 5]      $��4* �6+   �� 5^      $��4* �6+   .+�5`      �� $��0��6   $��0��6-   $��Fecha de Inicio��6:   $
��Left=�6T   $��Center=�6p   �� 5a      $��0��6   $��1��6-   $��Fecha de Fin��6:   $
��Left=�6Q   $��Center=�6m      FEI.pages.DatePickerEx  5b      -   5          Name$ datePick_inicio��5b   )   $��1��6B   $��0��6R   $��0,5,5,5q�6_   (  "System.Windows.Controls.DatePicker   IsDropDownOpen .     IsTodayHighlighted . 6�     5c      -   5        $ datePick_fin��5c   )   $��1��6?   $��1��6O   $��0,5,5,5q�6\    .   . 6�   �� 5d      $��2��6"   $��0��62   $��2��6?   $��2��6S   $��Right=�6d   $��Center=�6�   .+�5e      �� -   5        $��80��5e   !   $��0,0,5,0q�6,   .��5f      ��  �� Orientation$ 
Horizontal=�6)   .+�5g   "   �� -   5         ��Name$ imageButton��5g   (   $+��%/FEI;component/images/search-icon.png��6=   $
��Fill=�6l   $��15��6{   $��15��6�   �� 5h   "   $��Filtrar��6(   5i      5j      5k      5l      &   System.Windows.Controls.DataGrid  5m      -   5          Name$ dgComprobantes��5m   c   $��0��6   $��1��6+   $��
40,10,40,0q�68      FrozenColumnCount$ 0��6L     HeaderStyle   ColumnHeaderStyle# �  6{      AutoGenerateColumns .     CanUserAddRows .     SelectionMode$ Single=�5p         CanUserDeleteRows .     CanUserResizeRows .  
�������   HeadersVisibility$ Column=�5t         VerticalGridLinesBrush �#000000   GridLinesVisibility$
 None=�5v         SelectionUnit$ FullRow=�6.   $	��285��6G   $	��250��6W    5w        �� Color��%�   (��       5x   *   * SystemColors.HighlightBrushKey+)(�� !     5y   *   *$"SystemColors.HighlightTextBrushKey+)�� 5x      $  #DEDCD9��6\   �� 5y      $  Black��6`   5z      !   Columns! 5{      4  .System.Windows.Controls.DataGridTemplateColumn  5|      ,  &System.Windows.Controls.DataGridColumn"   MaxWidth$" 35Q�61   #   CanUserReorder# .  $   CanUserResize$ .  %   Header% 5}      �� 5~   "   -	   5        & ��Name$& chkAll��5~   H   $��Center=�6+   6q   '   CellTemplate' 5�      �� 5�   "   .R�5�   &   �� $��chkDiscontinue��6/   -
   5        ( d� 	IsChecked( 5�   F   �� ) �� Path$) Check�* �� Mode$* TwoWay=�6�   5�   #   +   	CellStyle+ 5�      �� 5�   "   *  $System.Windows.Controls.DataGridCell"  6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   5�   #   5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,   
IsReadOnly, . -   MinWidth$	- 150Q�6]   .   Width5  /System.Windows.Controls.DataGridLengthConverter$. 3* 6l   # .  1	  +System.Windows.Controls.DataGridBoundColumn/ 	  Binding/ 6-   �� *	TipoTexto+% 5�      �� 5�   "   $��Comprobante��6-   $��Center=�6@   $��Center=�6[   0 	  ElementStyle0 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   �� 5�   &    � ��$
 Wrap=�6O   5�   #   5�        5�      , . $	- 100Q�6_   $. 2* 6n   # .  1   SortDirection$1 	AscendingX�6�   2   CanUserSort2 . / 6-   �� *SerieNumero+% 5�      �� 5�   "   $��Serie-Número��6-   $��Center=�6A   $��Center=�6\   0 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   �� 5�   &    � ��$
 Wrap=�6O   5�   #   5�        5�      , . $- 70Q�6]   $. 2* 6k   # .  $1 	AscendingX�6�   2 . / 6-   �� *	EstadoSCC+% 5�      �� 5�   "   $��
Estado SCC��6-   $��Center=�6?   $��Center=�6Z   0 5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$
 Wrap=�6O   �� 5�   &    �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   3 �� Triggers3 5�   &   P� 5�   *    � ��$	 ENVIADO��6B   . �5�   .   ��  � ��
 � � �6K   5�   +   P� 5�   *    � ��$	 PENDIENTE (CORRECTO)��6B   . �5�   .   ��  � ��
 ��iA�6K   5�   +   P� 5�   *    � ��$	 PENDIENTE (ERRORES)��6B   . �5�   .   ��  � ��
 �  ��6K   5�   +   P� 5�   *    � ��$	 PENDIENTE (DE BAJA)��6B   . �5�   .   ��  � ��
 ��iA�6K   5�   +   5�   #   5�        5�      , . $- 80Q�6_   $. 2* 6m   # .  $1 	AscendingX�6�   2 . / 6-   �� *EstadoSunat+% 5�      �� 5�   "   $��Estado Sunat��6-   $��Center=�6A   $��Center=�6\   0 5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$
 Wrap=�6O   �� 5�   &    �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   3 5�   &   P� 5�   *    � ��$	 ACEPTADO��6B   . �5�   .   ��  � ��
 � � �6K   5�   +   P� 5�   *    � ��$	 	RECHAZADO��6B   . �5�   .   ��  � ��
 �**��6K   5�   +   P� 5�   *    � ��$	 SIN RESPUESTA��6B   . �5�   .   ��  � ��
 �  ��6K   5�   +   P� 5�   *    � ��$	 DE BAJA��6B   . �5�   .   ��  � ��
 �r���6K   5�   +   5�   #   5�        5�      , . $	- 100Q�6b   $. 2* 6q   # .  $1 	AscendingX�6�   2 . / 6/   �� *FechaEmision+% 5�      �� 5�   "   $��Fecha de emisión��6-   $��Center=�6E   $��Center=�6`   0 5�      �� 5�   "   .�5�   &   ��  �@��TextAlignment$
 Left=�6P   �� 5�   &    � ��$ Center=�6T   �� 5�   &    � ��$
 Wrap=�6O   5�   #   5�      5�      � 5�      $��0��6   $��2��6(   $��40,15,40,20q�65    5      �� 5     $
��Auto �6(    5     �� 5     $��1* �6+   �� 5     $��1* �6+   .+�5     ]� $��1��6"   $��0��62   .+�5     �� -   5        4 ��Name$4 btnEnviarAResumen��5  !   $	��151��6<   $��10,0,0,0q�6H   $��Right=�6Z   $��Bottom=�6�   .��5	     �� $ 
Horizontal=�6)   .+�5
  "   �� $(��"/FEI;component/images/add-list.png��6(   $��19��6T   $��26��6`   �� 5  "   -   5        $ 
TextoBoton��5  (   $��Resumen diario��6<   $��Center=�6W   $��Right=�6r   5     5     5     ]� 5     $��0��6"   $��0��62   .+�5     �� -   5        $4 btnDescartar��5  !   $	��111��67   $��0,0,0,0q�6C   $
��Left=�6T   $��Bottom=�6�   .��5     �� $ 
Horizontal=�6)   .+�5  "   �� $+��%/FEI;component/images/remove-icon.png��6(   $��19��6W   $��26��6c   �� 5  "   $��	Descartar��6)   $��Center=�6?   $��Right=�6Z   5     5     5     5     5     5     5     5     