   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FEIFEI  5   	       FEI.frmDetalleComprobante   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:FEI     5   	   -   5          � Title$  Detalle comprobante��5   	   $	��500��6&   $	��500��63    � Icon$ images/fei_cuadro.ico��6?    � 
ResizeMode$ NoResize=�6s    � WindowStartupLocation$ CenterScreen=�6�   .��5	      � $��20,20,20,15q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   $��45��6*   �� 5      $
��Auto �6   $��45��6*    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   .+�5   
   �� $��Tipo de comprobante:��6   $��Calibri)�6/   $��0��6D   $��0��6T   �� 5   
   -   5         ��Name$ txtTipoComprobante��5      $�� ��6.   $��	0,4,113,0q�66   $��1��6I   $��0��6Y   {�.  $��2��6x   �� 5   
   $��Serie-Numero:��6   $��Calibri)�6(   $��2��6=   $��0��6M   $��2��6Z   $��0.5,0,112.5,0q�6n   �� 5   
   -   5        $ txtSerieNumero��5      $�� ��6*   $��
0,4,-1.5,0q�62   $��3��6F   $��0��6V   {�.  6c   �� 5   
   $
��RUC:��6   $��Calibri)�6   $��0��64   $��1��6D   �� 5   
   -   5        $ txtRuc��5      $�� ��6"   $��	0,4,113,0q�6*   $��1��6=   $��1��6M   {�.  $��2��6l   �� 5!   
   $��Fecha de emision:��6   $��Calibri)�6,   $��2��6A   $��1��6Q   $��2��6^   $��0.5,0,112.5,0q�6r   �� 5"   
   -   5        $ txtFechaEmision��5"      $��
0,4,-1.5,0q�6,   $�� ��6@   $��3��6H   $��1��6X   {�.  6e   �� 5$   
   $��Razon Social:��6   $��Calibri)�6(   $��0��6=   $��2��6M   �� 5%   
   -   5        $ txtRazonSocial��5%      $�� ��6*   $��	0,4,0.5,0q�62   $��1��6E   $��3��6U   $��2��6i   {�.  6v   &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ 
dgEmpresas��5'   r   $��0��6   $��3��6#   $��4��61   $��0,20,0.5,20q�6E      FrozenColumnCount$ 0��6[   	   AutoGenerateColumns	 .  
   CanUserAddRows
 .     SelectionMode$ Single=�5*         CanUserDeleteRows .     CanUserResizeRows .  
�������   HeadersVisibility$ Column=�5.         VerticalGridLinesBrush �#000000   GridLinesVisibility$
 None=�50         SelectionUnit$ FullRow=�6.   $	��250��6G   $	��100��6W      Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    MinWidth$ 90Q�6c      CanUserReorder .     Width5  /System.Windows.Controls.DataGridLengthConverter$ 4* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Cs_tag_invoicedQuantity+   Header 53      �� 54      $��Descripción��6$   $��Center=�67   $��Center=�6R      HeaderStyle 56      �� 57       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .�58      ��  �� Property � �� �� Value$ Center=�6L   59         ElementStyle 5;      �� 5<      .�5=      ��  �@��TextAlignment$
 Left=�6H   �� 5>       � ��$
 Wrap=�6G   5?      5A        5B       . $ 90Q�6q    .  $ * 6�    6%   �� *'%Cs_tag_Item_SellersItemIdentification+ 5C      �� 5D      $��Cantidad��6%   $��Center=�65   $��Center=�6P    5F      �� 5G      "  6    .�5H      ��  � ��$ Center=�6L   5I       5K      �� 5L      .�5M      ��  �@��TextAlignment$ Center=�6H   5N      5P        5Q       . $ 90Q�6q    .  $ * 6�    6%   �� *'%Cs_tag_LineExtensionAmount_currencyID+ 5R      �� 5S      $��Precio��6%   $��Center=�63   $��Center=�6N    5U      �� 5V      "  6    .�5W      ��  � ��$ Center=�6L   5X       5Z      �� 5[      .�5\      ��  �@��TextAlignment$ Center=�6H   5]      5_      5b      �� 5c   
   -   5         ��Name$ btnXMLEnvio��5c   �   $	��140��6   $��Descargar XML Envio��6   $��2q�6<   $��0��6H   $��2��6X   $��4��6l   $��0,0,0,10q�6z   $
��Left=�6�   $��Bottom=�6�   $��23��6�   5d      �� 5e   
   -	   5        $ btnXMLRecepcion��5e   �   $	��140��6   $��Descargar XML Recepcion��6   $��2q�6?   $��1��6K   $��2��6\   $��4��6p   $��	44,0,2,10q�6~   $
��Left=�6�   $��Bottom=�6�   $��23��6�   5g      �� 5h   
   -
   5        $ btnRepresentacionImpresa��5h   �   $	��140��6   $��Representacion Impresa��6   $��2q�6>   $��2��6J   $��2��6Z   $��4��6n   $��0,0,-1.5,10q�6|   $��Right=�6�   $��Bottom=�6�   $��23��6  5j      �� 5k   
   -   5        $ 
btnRemover��5k   p   $��Salir��6   $��2q�6"   $	��100��6.   $��1��6:   $��5��6J   $��64.5,0,62.5,10q�6X   $��Center=�6�   $��Bottom=�6�   $��2��6�   $��23��6�   5l      5o      5p      