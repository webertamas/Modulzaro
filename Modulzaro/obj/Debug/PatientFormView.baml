   M S B A M L   `   `   `  ����D  @Modulzaro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Modulzaro	Modulzaro  5   	       Modulzaro.PatientFormView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Modulzaro     5   	   -   5          � Title$  PatientFormView��5   	   $��353.509��6!   $��564.035��62   .��5	      � .+�5
   
   �� $��Beteg neve:��6   $
��Left=�6&   $��27��6A   $��	26,29,0,0q�6M   $	��Top=�6`   $	��118��6x   �� 5   
   $��Születési hely:��6   $
��Left=�6*   $��42��6E   $��	26,90,0,0q�6Q   $	��Top=�6d   $	��118��6|   �� 5   
   $��Születési dátum:��6   $
��Left=�6+   $��30��6F   $��
26,148,0,0q�6R   $	��Top=�6f   $	��118��6~   �� 5   
   $��
TAJ szám:��6   $
��Left=�6$   $��27��6?   $��
26,206,0,0q�6K   $	��Top=�6_   $	��118��6w   �� 5   
   $��	Életkor:��6   $
��Left=�6#   $��42��6>   $��
304,90,0,0q�6J   $	��Top=�6^   $��48��6v   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��30��60   $��149,148,0,0q�6<   $	��Top=�6Q   $	��150��6i      SelectedDate 6u   �� *Patient.BirthDate+�� 5   
   $
��Left=�6   $��27��6-   $��
149,29,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6   $	��150��6�   ��6a   �� *Patient.Name+6�   �� 5   
   $
��Left=�6   $��27��6-   $��
149,90,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��150��6�   ��6a   �� *Patient.BirthPlace+6�   �� 5   
   $
��Left=�6   $��27��6-   $��149,206,0,0q�69   $
 Wrap=�6N   $	��Top=�6   $	��150��6�   ��6b   �� *Patient.SSN+6�   �� 5   
   $��Label��6   $
��Left=�6    $��42��6;   $��
393,90,0,0q�6G   $	��Top=�6[   $��48��6s   �� 5   
   -   5        $��OK��5      $
��Left=�6   $��39��69   $��240,262,0,0q�6E   $	��Top=�6Z   $��80��6r   6}   5      5      