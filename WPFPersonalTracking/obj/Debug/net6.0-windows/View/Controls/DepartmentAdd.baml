   M S B A M L   `   `   `  ����N  JWPFPersonalTracking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:WPFPersonalTracking.View.Controls!WPFPersonalTracking.View.Controls  5      5    /WPFPersonalTracking.View.Controls.DepartmentAdd   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:WPFPersonalTracking.View.Controls     5      .��5	   
   �   � ColumnDefinitions  5
      �� 5      $
��auto �6#   �� 5      $
��auto �6#    � RowDefinitions 5      �� 5      $��50 �6    �� 5      $��50 �6!   .+�5   
   �� -   5         ��Name$ id��5      $y�Hidden=�63   ��6   �� *Id+63   �� 5   
   -   5        $ lblDepartment��5      $��Department Name��6'   $
��Left=�5      $��Center=�60   $��18(�5      $
��Bold"�6"   �� 5      -   5         ��Name$ txtName��5      $��1��6'   $	��120��67   $
��Left=�5      $��Center=�64   $��18(�5      $
��Bold"�6'   ��69   �� *Department.Name+ �� Mode$ TwoWay=��� 5      -   5         ��Name$ btnSave��5      $��1��6&   $
��Save��64   $	��100��6C   $
��Left=�5      $��Center=�5      $��18(�5      $
��Bold"�6#   ��5      �� *
AddCommand+�� 5      -   5        $ 	btnCancel��5      $��1��6(   $��1��66   $��Cancel��5       $	��100��6&   $
��Left=�5!      $��Center=�5"      $��18(�5#      $
��Bold"�6#   65   5%      5&      