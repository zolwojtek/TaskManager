   M S B A M L   `   `   `  ����F  BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TaskManagerTaskManager  5          TaskManager.NewTaskDialog   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:TaskManager     5      .��5	      �   � DataContext  6   ��  �� ElementName$
 root��.+�5
   
   �� ���	#90000000$��0,0,-236,-594q�6J   $
��1200��6a   $	��Top=�6o   y�6(   �� *
Visibility+._�5      �� 
���   �$��1q�6)   
������� �� CornerRadius$ 	10,0,10,0��5      $��Center=�6*   $��Center=�5      $	��408��6.   $��68,46,43,746q�6;   $	��425��6Q    J� BitmapEffect 5      F� 5       F� Color$ Black��6-    F� Opacity$	 0.5Q�5       F� 	Direction$	 270Q�6!    F� ShadowDepth$	 0.7Q�5      ._�5      � $��10q�6    � RowDefinitions 5      �� 5      �� 5      $
��Auto �6(   .+�5      �� -   5        	 ��Name$	 
TitleLabel��5      $��ADDING NEW TASK��60   $��130,10,113,338q�6J   $��Center=�6b   �� 5      -   5        $	 ContentLabel��5      $��Content:��62   $��28,48,215,218q�6E   �� 5      -   5        
 ��Name$
 contentTextBox��5      $
��Left=�66   $��70��6Q    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��356��6�    �� 	IsEnabled .  �� 	MaxLength$
 1000��6�   $��	28,76,0,0q�6�   �� 5       -   5        $	 CalendarLabel��5       $��Due date (optional):��63   $��28,158,192,183q�6R   &   System.Windows.Controls.Calendar  5!      -   5          Name$ dueDateCalendar��5!      $
��Left=�68   $	��Top=�6S   $	��201��6k   $	��183��6x   $��28,186,0,-18q�6�   $��2��6�   �� 5#      -   5        $	 PriorityLabel��5#      $��Priority��63   $��241,158,89,185q�6F   �� 5$      -   5         ��Name$ priorityComboBox��5$      $
��Left=�69   $	��Top=�6T   $	��143��6l    �� SelectedIndex$ 1��6x   $��241,189,0,0q�6�   �� 5'      -   5         ��Name$ OkButton��5'      $��Ok��5)      $��332,318,19,25q�6(   �� 5*      -	   5        $ CancelButton��5*      $��Cancel��5.      $��278,318,76,25q�6,    J� RenderTransformOrigin$ 2.795,-1.467&�6C   5/      50      51      52      53      