   M S B A M L   `   `   `  ����E  AWPF_client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_client
WPF_client  5   	   )    #WPF_client.ChangeUserDataViewWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF_client     5   	     � Title$  Change datas��5   	   $	��250��6   $	��250��6.   $	��350��6;   $	��250��6K   $	��250��6Z   $	��350��6f   .��5	      �    DarkBackgroundBrush#���   6    � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��0.7* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Change data��6   $��2��6&   $��Center=�6:   $��Center=�6W     LightForegroundBrush#���  6r   $��20(�6�   �� 5   
   $��New username: ��6   $��1��6)   $��Right=�66   $��Center=�6R   #���  6m   $��16(�6�   �� 5   
   $��New password: ��6   $��2��6)   $��Right=�66   $��Center=�6R   #���  6m   $��16(�6�   �� 5   
   $��Old password: ��6   $��3��6)   $��Right=�66   $��Center=�6R   #���  6m   $��16(�6�   �� 5   
   $��Show passwords��6   $��4��6)   $��1��66   $��Right=�6F   $	��Top=�6b   #���  6z   $��12(�6�   �� 5   
   -   5         ��Name$ tb_username��5      $��1��6'   $��1��64   $��10,10q�6D   �� 5   
   -   5        $ tb_newPassword��5      $��2��6*   $��1��67   $��10,10q�6G   $y�	Collapsed=�6V   G� 5    
   -   5         G�Name$ pb_newPassword��5       $��2��6.   $��1��6;   $��10,10q�6K   �� 5"   
   -   5        $ tb_password��5"      $��3��6'   $��1��64   $��10,10q�6D   $y�	Collapsed=�6S   G� 5#   
   -   5        $ pb_password��5#      $��3��6+   $��1��68   $��10,10q�6H   �� 5%   
   -   5         ��Name$ cb_show_password��5%      $��4��6-   $��1��6:   $��0,0,95,0q�6J   $��Right=�6]   $��Center=�6y   6�   �� 5&   
   -   5         ��Name$ btn_ok��5&      $��Ok��6!   $��5��6.   $��2��6;   $��16(�6O     LightBackgroundBrush#���  6r   #���  6�   5'      5(      