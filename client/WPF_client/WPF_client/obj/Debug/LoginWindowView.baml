   M S B A M L   `   `   `  ����E  AWPF_client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_client
WPF_client  5   	        WPF_client.LoginWindowView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF_client     5   	     � Title$  Login��5   	   $	��220��6   $	��200��6$   $	��260��64   $	��260��6D   $	��260��6P   $	��360��6_    � 
ResizeMode$ CanResizeWithGrip=�6n   .��5	      �    DarkBackgroundBrush#���   6    � RowDefinitions 5
   
   �� 5      $��70��6   $��1* �6+   �� 5      $��30��6   $��1* �6+   �� 5      $��30��6   $��1* �6+   �� 5      $��15��6   $
��0.7* �6+   �� 5       � ColumnDefinitions 5   
   �� 5      $��30��6   $	��100 �6-   �� 5      $��* �6   .+�5   
   �� $��Images/logo.png��6   $��10q�6)   $��0��65   $��0��6E   $��2��6R   �� 5   
   $��	Username:��6   $��23��6$   $��Right=�60   $��1��6L     LightForegroundBrush#���  6Y   �� 5   
   -   5         ��Name$ tb_username��5      $��23��6'   $��5,5,40,0q�63   $��1��6E   $��1��6R   $��Stretch=�6b   �� 5   
   $��	Password:��6   $��23��6$   $��Right=�60   $��2��6L   #���  6Y   G� 5   
   -   5         G�Name$ pb_password��5      $	��150��6+   $��23��6:   $��5,5,40,0q�6F   $��2��6X   $��1��6e   $��Stretch=�6u   �� 5   
   -   5         ��Name$ 
lbl_signUp��5      $��Sing Up��6$   $��3��66   $��2��6C   $��Center=�6W   $��8(�6t     	LinkBrush#���  6�   6�   �� 5    
   -   5         ��Name$ 	btn_login��5       $��Login��6$   $��30��64   $��Bottom=�6@   $
��Bold"�6[   $��4��6m   $��0��6z   $��2��6�     LightBackgroundBrush#���  6�   #���  6�   6  5"      5#      