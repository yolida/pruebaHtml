   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FEIFEI  5   	       FEI.Usuarios   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:FEI     5   	   -   5          � Title$  Registro de usuario��5   	   $	��250��6%   $	��350��62    � WindowStartupLocation$ CenterScreen=�6>   .��58      � $��
20,20,20,0q�6   $	��Top=�6     � RowDefinitions 59   
   �� 5:      $
��Auto �6   �� 5;      $
��Auto �6   �� 5<      $
��Auto �6   �� 5=      $
��Auto �6    � ColumnDefinitions 5?   
   �� 5@      $��1* �6   �� 5A      $��1* �6   .+�5D   
   �� $��Usuario:��6   $
��Left=�6#   $��0��6E   $��0��6R   $��	0,10,0,10q�6b   $
��Bold"�6v   �� 5E   
   -   5         ��Name$ 
txtUsuario��5E      $��0��6O   $��1��6\   $��	0,10,0,10q�6l   $	��140��6�   $��Right=�6�   �� 5G   
   $��0��6   $��1��6    $��Contraseña:��6-   $��	0,10,0,10q�6D   $
��Left=�6W   $
��Bold"�6y   G� 5H   
   -   5         G�Name$ txtContrasenia��5H   B   $��1��6Z   $��1��6j   $��	0,10,0,10q�6w   $	��140��6�   $��Right=�6�   �� 5J   
   $��0��6   $��2��6    $��Confirmar contraseña:��6-   $��	0,10,0,10q�6N   $
��Left=�6a   $
��Bold"�6�   G� 5K   
   -   5        $ txtVerificacionPass��5K   G   $��1��6d   $��2��6t   $��	0,10,0,10q�6�   $	��140��6�   $��Right=�6�   �� 5M   
   -   5         ��Name$ btnSalir��5M   B   $��0��6   $��3��6"   $��0,10,0,0q�60   $��Center=�6T   $	��Top=�6r   .��5N      ��  �� Orientation$ 
Horizontal=�6   .+�5O      �� -   5         ��Name$ imageBotonSalir��5O      $��images/salir-sesion.png��61   $��18��6R   $��60��6^   �� 5P      -   5        	 ��Name$	 TextBotonSalir��5P      $��Salir��60   $��Center=�6@   5Q      5R      �� 5T   
   -   5        $ 
btnGuardar��5T   B   $��1��6   $��3��6"   $��0,10,0,0q�60   $��Center=�6V   $	��Top=�6t   .��5U      �� $ 
Horizontal=�6   .+�5V      �� -	   5        $ 
imageBoton��5V      $��images/save-icon.png��6,   $��18��6J   $��60��6V   �� 5W      -
   5        $	 	TextBoton��5W      $��Guardar��6+   $��Center=�6=   5X      5Y      5Z      5[      