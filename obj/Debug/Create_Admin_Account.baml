   M S B A M L   `   `   `  ����I  EQuanLyDoanVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:QuanLyDoanVienQuanLyDoanVien  5   	   )    #QuanLyDoanVien.Create_Admin_Account   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:QuanLyDoanVien     5   	     � Title$  Tạo tài khoản��5   	   $	��333��6   $	��295��6,    � WindowStartupLocation$ CenterScreen=�68    � 
ResizeMode$ NoResize=�6]   .��5	      � .+�5
   
   �� $��Tên tài khoản��6   $
��Left=�6(   $��	10,70,0,0q�6C   $	��Top=�6V   �� 5   
   $��Mật khẩu��6   $
��Left=�6#   $��
10,119,0,0q�6>   $	��Top=�6R   �� 5   
   $��Xác nhận��6   $
��Left=�6#   $��
12,174,0,0q�6>   $	��Top=�6R   �� 5   
   -   5         ��Name$ tb_UserName��5      $
��Left=�6'   $��24��6B   $��
120,70,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   6�   G� 5   
   -   5         G�Name$ ps_Password��5      $
��Left=�6+   $��120,125,0,0q�6F   $	��Top=�6[   $	��120��6s   6   G� 5   
   -   5        $ ps_Confirm_Password��5      $
��Left=�63   $��120,180,0,0q�6N   $	��Top=�6c   $	��120��6{   6�   �� 5   
   -   5         ��Name$
 Tick��5      $
��Left=�6   $��20��69   $��250,180,0,0q�6E   $	��Top=�6Z   $��20��6r   �� 5   
   $��Chức vụ��6   $
��Left=�6"   $��
10,219,0,0q�6=   $	��Top=�6Q   �� 5   
   $
��Left=�6   $��26��6.   $��120,219,0,0q�6:   $	��Top=�6O   $	��120��6g    �� View 5      �� 5      .P�5      �� 5      5      �� 5   
   -   5         ��Name$ bt_Add��5      $��Thêm��6!   $
��Left=�60   $��
54,262,0,0q�6K   $	��Top=�6_   $��75��6w   6�   �� 5   
   -   5        $ 	bt_Cancle��5      $��Thoát��6$   $
��Left=�64   $��152,262,0,0q�6O   $	��Top=�6d   $��75��6|   6�   5      5      