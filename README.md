# Ratio_cents
 A small tool to help build Microtonal Scale. Trans cents to frequency ratios.  
   
 可以快速用于推测微分音音阶上各个音接近的频率比，特别是一些Xenharmonic Wiki上没有说明的，也可以用于生成BRSO键盘表
## Install 
 Vistual Studio 2022: .Net 6.0
## Code Document
 Ratio_cents.sln --- 解决方案文件，用 Vistual Studio 打开  
 /Ratio_cents/Controller/Utils.cs --- 计算结果等工具函数在这  
 /Ratio_cents/Models/FormStatus.cs --- 用于确定是否更新了列表的状态的类  
 /Ratio_cents/Models/Limit.cs --- 限  
 /Ratio_cents/Models/Ratio.cs --- 频率转换相关内容  
 /Ratio_cents/Models/Scale_To_Ratio_Result.cs --- 存放结果的类以及用于排序的委托  
 /Ratio_cents/Form1.cs --- 含有各类窗体事件响应函数   
 /Ratio_cents/Form1_Data.cs --- 窗体中共用的存放结果的数据会实例化在这里  
## How To Use
### 主界面如图：  
  在左上角输入比例，点击“计算音分”，就会计算出音分。点击推测纯律，就会显示可能的比例。  
    
  最大频率比：最大允许的频率，比如默认值81就代表最大81:1, 81:80，不会出现82:1，不要设置得太大，最大是1000，可能会搜索十几秒  
    
  最大质数限：允许出现的最大的质数限值。  
    
  质数限列表：只产生可能的选框，可以人工去掉不想要的质数限。 
      
  最大奇数限：允许出现的最大的奇数限值。
     
  奇数限列表：只产生可能的选框，可以人工去掉不想要的奇数限。
             
  清除限制/使用配置：初始化限相关。
    
  更新列表：更新限列表以便重新勾选。
           
  (关于限的含义，请查看Xenharmonic Wiki)  
     
  显示最简比例：如6:4=3:2，则丢弃6:4这个重复的结果，推荐开启。 
     
  最大音分允许误差：如需要搜索的音分是纯五度702cents，设置为30 则搜索区间为 672 - 732，默认值为30，一般不需要更改。
       
  八度允许：某些情况下搜索的结果可能高于八度，如3:4和3:2等价，设置为一个八度以内时搜索音分区间在0-1200。 
         
  结果显示简化：只适用于左侧推测纯律，开启后保留2位小数显示。
           
  输出推测结果：可以输出csv文件，也可以输出excel（需要电脑安装了excel）。

  
    
  ![image](https://github.com/Yuyu0914/Ratio_cents/blob/main/Readme_Picture/%E4%BD%BF%E7%94%A8%E8%AF%B4%E6%98%8E1.PNG)  
### 平均律搜索相关
  快速创建平均律音阶并进行显示。  
  显示结果：弹出一个窗口显示。  
  复制结果：复制到剪贴板。  
  输出：可以输出到txt/excel。  
### 结果排序依据
  只使用与平均律搜索与音阶搜索，可以排序显示结果。  
    
  ![image](https://github.com/Yuyu0914/Ratio_cents/blob/main/Readme_Picture/%E4%BD%BF%E7%94%A8%E8%AF%B4%E6%98%8E2.PNG)  
### 自定义音阶输入
  输入音分值，相邻的值用逗号","分割。  
    
  ![image](https://github.com/Yuyu0914/Ratio_cents/blob/main/Readme_Picture/%E4%BD%BF%E7%94%A8%E8%AF%B4%E6%98%8E3.PNG)  
### BRSO 功能 （piano roll key names）
  有个FL Studio 插件叫做BRSO，可以自定义键盘文字，这个功能用于辅助生成键盘。  
  Midi 键盘包括0-127总共128个音，默认配置给出的就是一个十二平均律的标，一个八度内如图所示，钢琴卷帘从上往下看的那种。  
  我想让C5按照标准那种在48号音，所以我写48，他是第五个C，所以上面输入5。（左侧输入从上往下看C是最低的那个音）  
  去掉追加音高数字后，就不显示C5，只显示C了，可选。  
  导出结果是一个txt文件，导入BRSO的方法看下面，piano roll key names。  
  如果实在弄不明白，不妨修改下默认配置（生成标准十二平均律键盘）看看结果？  
     
  ![image](https://github.com/Yuyu0914/Ratio_cents/blob/main/Readme_Picture/%E4%BD%BF%E7%94%A8%E8%AF%B4%E6%98%8E4.PNG)  
  ![image](https://github.com/Yuyu0914/Ratio_cents/blob/main/Readme_Picture/%E4%BD%BF%E7%94%A8%E8%AF%B4%E6%98%8E5.PNG)  
  
## Change Log
 None. 
