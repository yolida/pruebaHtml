   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FEIFEI  5   	       FEI.ActivacionManual   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:FEI     5   	   -   5          � Title$  Activacion Manual��5   	   $	��340��6#   $	��400��60    � WindowStartupLocation$ CenterScreen=�6=    � 
ResizeMode$ NoResize=�6b    � Icon$ images/fei_cuadro.ico��6x   .��5	      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   .+�5   
   �� $��0��6   $��3��6"   $��20,5,0,1q�66   $��0��6H   $��Código de Activación��6V   �� 5   
   -   5         ��Name$ txtCodigoActivacion��5   C   $��0��6   $��6��6"   $��1��66   $��	20,5,20,5q�6`    �� TextWrapping$
 Wrap=�6s   $�� ��6�   �� 5   
   $��0��6   $��3��6"   $��20,5,0,1q�66   $��2��6H   $��Código de Autorización��6V   �� 5   
   -   5        $ txtCodigoPeticion��5   C   $��0��6   $��6��6"   $��3��66   $��	20,5,20,5q�6^   $
 Wrap=�6q   $�� ��6�   {�.  6�   �� 5    
   $��0��6   $��2��6"   $��20,5,0,1q�66   $��4��6H   $��Licencia��6V   �� 5!   
   -   5        $ txtCodigoLicencia��5!   C   $��0��6   $��6��6"   $��5��66   $��70��6^   $��
20,5,20,15q�6j   $
 Wrap=�6~   $�� ��6�    �� AcceptsReturn . 6�   �� 5"   
   -   5        	 ��Name$	 
btnGenerar��5"   T   $��0��6   $��4��6!   $��20,0,0,0q�65   $��6��6G   $&�� Generar archivo de autorización��6h   $
��Left=�6�   $	��200��6�   $��20��6�   $	��Top=�6�   6�   �� 5$   
   -   5        $	 	btnEnviar��5$   ?   $��4��6   $��0,0,0,0q�6!   $��6��62   $��Activar��6R   $
��Left=�6e   $��50��6�   $��20��6�   $	��Top=�6�   6�   �� 5%   
   -   5        $	 btnCancelar��5%   B   $��4��6   $��2��6!   $��6��65   $��50��6W   $��20��6b   $��Cancelar��6n   $��0,0,20,0q�6�   $��Right=�6�   $	��Top=�6�   6�   5&      5'      