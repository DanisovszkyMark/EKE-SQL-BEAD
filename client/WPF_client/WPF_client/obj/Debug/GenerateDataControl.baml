   M S B A M L   `   `   `  ����E  AWPF_client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_client
WPF_client  5      $    WPF_client.GenerateDataControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:WPF_client     5      .��5	      �    DarkBackgroundBrush#���   6     � RowDefinitions  5
   
   �� 5      $��80��6   $	��80* �6+   �� 5      $��40��6   $	��80* �6+   �� 5      $��40��6   $	��80* �6+   �� 5      $��40��6   $	��80* �6+   �� 5      $	��100��6   $
��150* �6,    � ColumnDefinitions 5   
   �� 5      $��50��6   $	��150 �6-   �� 5      $	��150��6   $
��150* �6.   .+�5   
   �� $��Generate Datas��6   $��Center=�6)   $��0,20,0,0q�6F   $��0��6X   $��0��6e   $��2��6u     LightForegroundBrush#���  6�   $��30(�6�   �� 5   
   $��Table name: ��6   $��1��6'   $��Center=�64   $��Right=�6O   #���  6k   $��16(�6�   �� 5   
   -   5         ��Name$ tb_tableName��5      $��Persons��6(    �� 
IsReadOnly . $��40��6I   $	��500��6W   $��20q�6f   $��1��6r   $��2��6   $��16(�6�   �� 5   
   $��Number of records: ��6   $��2��6.   $��Center=�6;   $��Right=�6V   #���  6r   $��16(�6�   �� 5   
   -   5        $ tb_numberOfRecords��5      $��40��6/   $	��500��6=   $��20q�6L   $��2��6X   $��2��6e   $��16(�6u   �� 5   
   $��Drop first: ��6   $��3��6'   $��Center=�64   $��Right=�6O   #���  6k   $��16(�6�   �� 5   
   -   5         ��Name$ cb_dropFirst��5      $��3��6)   $��1��66   $��20,0,0,0q�6F   $
��Left=�6X   $��Center=�6s    � LayoutTransform 5       �� 5!       �� ScaleX$ 2Q�6!    �� ScaleY$ 2Q�6,   5#      �� 5%   
   -   5         ��Name$ btn_generate��5%      $��Generate��6'   $��Bottom=�6:   $	��400��6U   $��80��6d   $��50��6s   $��4��6�   $��2��6�   $��50,20,50,20q�6�   $��22(�6�   6�   5&      5(      