   M S B A M L   `   `   `  ����E  AWPF_client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_client
WPF_client  5   	   #    WPF_client.RegisterViewWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF_client     5   	     � Title$  Registration��5   	   $	��260��6   $	��260��6,   $	��300��6<   $	��360��6H   .��5	      �    DarkBackgroundBrush#���   6    � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��30��6   $	��100 �6-   �� 5      $��* �6   .+�5   
   �� $��Sign Up��6   $��2��6"   $��Center=�66   $��Center=�6S     LightForegroundBrush#���  6n   $��20(�6�   �� 5   
   $��
Username: ��6   $��1��6%   $��Right=�62   $��Center=�6N   #���  6i   $��16(�6�   �� 5   
   $��
Password: ��6   $��2��6%   $��Right=�62   $��Center=�6N   #���  6i   $��16(�6�   �� 5   
   $��Again: ��6   $��3��6"   $��Right=�6/   $��Center=�6K   #���  6f   $��16(�6�   �� 5   
   $��Show passwords��6   $��4��6)   $��1��66   $
��Left=�6F   $��	15,10,0,0q�6a   $	��Top=�6t   #���  6�   $��12(�6�   �� 5   
   -   5         ��Name$ tb_username��5      $��1��6'   $��1��64   $��10,10q�6D   �� 5   
   -   5        $ tb_password��5      $��2��6'   $��1��64   $��10,10q�6D   $y�	Collapsed=�6S   G� 5    
   -   5         G�Name$ pb_password��5       $��2��6+   $��1��68   $��10,10q�6H   �� 5"   
   -   5        $ tb_passwordAgain��5"      $��3��6,   $��1��69   $��10,10q�6I   $y�	Collapsed=�6X   G� 5#   
   -   5        $ pb_passwordAgain��5#      $��3��60   $��1��6=   $��10,10q�6M   �� 5%   
   -   5         ��Name$ cb_show_password��5%      $��4��6-   $��1��6:   $
��Left=�6J   $��Center=�6e   6�   �� 5&   
   -   5         ��Name$ btn_ok��5&      $��Ok��6!   $��5��6.   $��2��6;   $��16(�6O     LightBackgroundBrush#���  6r   #���  6�   5'      5)      