   M S B A M L   `   `   `  ����I  EQuanLyDoanVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:QuanLyDoanVienQuanLyDoanVien  5   	       QuanLyDoanVien.Admin_List   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:QuanLyDoanVien     5   	     � Title$  Danh sách Admin��5   	   $	��600��6!   $	��300��6.    � WindowStartupLocation$ CenterScreen=�6:   .��5	      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Admin_DataGrid��5      $
��Left=�6%   $	��309��6@   $��
10,251,0,0q�6M   $	��Top=�6a   $	��272��6y      SelectionMode$ Single=�5         SelectionUnit$ FullRow=�6$      
IsReadOnly . 6r   �� 5   
   -   5         ��Name$ 	Add_admin��5      $��Thêm��6$   $��Right=�63   $��0,224,230,0q�6O   $	��Top=�6d   $��52��6|   {�.  6�   �� 5   
   -   5        $ Modify_admin��5      $��Sửa��6'   $
��Left=�65   $��
67,224,0,0q�6P   $	��Top=�6d   $��52��6|   {�.  6�   �� 5   
   -   5        $ Delete_admin��5      $
��Xóa��6'   $
��Left=�65   $��124,224,0,0q�6P   $	��Top=�6e   $��52��6}   {�.  6�   �� 5   
   $��	Mã admin��6   $
��Left=�6#   $	��Top=�6>   $��	10,19,0,0q�6V   �� 5   
   $��	Họ Tên��6   $
��Left=�6!   $	��Top=�6<   $��	10,50,0,0q�6T   �� 5   
   $��Chức vụ��6   $
��Left=�6"   $	��Top=�6=   $��	10,81,0,0q�6U   �� 5   
   -   5         ��Name$ tb_Admin_ID��5      $
��Left=�6'   $��23��6B   $��	91,21,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6v   $	��143��6�   {�.  6�   �� 5   
   -   5        $ tb_Admin_Name��5      $
��Left=�6)   $��23��6D   $��	91,52,0,0q�6P   $
 Wrap=�6c   $	��Top=�6x   $	��143��6�   {�.  6�   �� 5   
   -   5        $ tb_Admin_Position��5      $
��Left=�6-   $��23��6H   $��	91,83,0,0q�6T   $
 Wrap=�6g   $	��Top=�6|   $	��143��6�   {�.  6�   5      5      