   M S B A M L   `   `   `  ����L  HAppointmentSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AppointmentSystemAppointmentSystem  5   	   )    #AppointmentSystem.AppointmentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:AppointmentSystem     5   	     � Title$  AppointmentWindow��5   	   $	��550��6#   $	��450��60   
�������.��5	      �� $��10q�6   .+�5   
   �� -   5        $��lblName��5   %   $��Hasta İsmi��6   6%   �� 5   
   -   5        $��txtPatientName��5   .   $�� ��6    �� TextWrapping$
 Wrap=�6   6.   �� 5   
   -   5        $��
lblSurname��5   (   $��Hasta Soyismi��6   6(   �� 5   
   -   5        $��txtPatientSurname��5   .   $�� ��6   $
 Wrap=�6   6.   �� 5   
   -   5        $��polyclinicName��5   %   $��
Poliklinik��6   6%   �� 5   
   -   5        $��departmantComboBox��5   %    �� 
IsEditable$
 True��6   5      �� 5   
   -   5        $��	btnUpdate��5   H   
����·�$��Doktorları Listele��6+   6s   �� 5   
   -   5        $��	lbldoctor��5   !   $��Doktor��6   6!   �� 5   
   -	   5        $��titleComboBox��5   %   $
 True��6   5      �� 5   
   -
   5        $��lblAppointmentDate��5   )   $��Randevu Tarihi��6   6)   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dtpAppointmentDate��5      �� 5   
   -   5        $��btnSave��5   =   
��� �|�$��
Randevu Al��6(   6L   �� 5    
   -   5        $��	btnDelete��5    0   
���  ��$	��Sil��6"   6[   &   System.Windows.Controls.DataGrid  5!   
   -   5        $��dgAppointments��5!      $	��200��6)   5#      5$      