   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   C ?Planning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PlanningPlanning 5   	      Planning.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   (localclr-namespace:Planning     5   	   -   5          � Title$  Planning app��5	   	   $��421.012��6   $��424.136��6/    � WindowStartupLocation$ CenterScreen=�6?    � WindowStyle$ ThreeDBorderWindow=�6d    � 
ResizeMode$ NoResize=�5
   	   .��5      � .+�5   
   �� -   5         ��Name$ btnShow��5      $��Show Planning��6"   $
��Left=�6:   $��
288,44,0,0q�6U   $	��Top=�6i   $	��106��6�   6�   �� 5   
   -   5        $ btnAdd��5      $��Add New Planning��6!   $
��Left=�6<   $��276,339,0,0q�6W   $	��Top=�6l   $	��118��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��start��5   [   $
��Left=�6   $��	91,44,0,0q�60   $	��Top=�6C      FirstDayOfWeek$ Monday=�6h      IsTodayHighlighted . 6�     5   
   -   5        $	��end��5   \   $
��Left=�6   $��
91,227,0,0q�60   $	��Top=�6D   6\   �� 5   
   -   5         ��Name$ label��5      $��
Start date��6   $
��Left=�64   $��7,44,0,0q�6O   $	��Top=�6a   �� 5   
   -   5        $ label1��5      $��End date��6    $
��Left=�63   $��
11,227,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $ label2��5      $��	Component��6    $
��Left=�64   $��	7,107,0,0q�6O   $	��Top=�6b   �� 5   
   -	   5         ��Name$ 
txtSubject��5      $
��Left=�6&   $��23��6A   $��
91,107,0,0q�6M   	 �� TextWrapping$
	 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -
   5        $ label2_Copy��5      $��Description��6%   $
��Left=�6;   $��	7,165,0,0q�6V   $	��Top=�6i   �� 5   
   -   5        $ txtDesc��5      $
��Left=�6#   $��23��6>   $��
91,165,0,0q�6J   $
	 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        
 ��Name$
 cmbPriority��5      $
��Left=�6(   $��
91,281,0,0q�6C   $	��Top=�6W   $	��120��6o   �� 5   
   -   5        $ label3��5      $��Priority��6    $
��Left=�63   $��
11,281,0,0q�6N   $	��Top=�6b   $��57��6z   5      5      