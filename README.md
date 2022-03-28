# **VB大作业——公益羽毛球赛**

## **1.**   **大作业主题介绍**

本次大作业的主题是“希望杯”公益羽毛球赛，目的是加强人民群众对于体育锻炼、体育赛事的参与度，弘扬奋勇拼搏、永不言弃的体育精神。本届比赛分为学生组和教职工组，其中学生组限定报名人数为8人，教职工组限定报名人数为16人。学生组采用的比赛形式为单打比赛，教职工组将抽签组成8支双打队伍进行比赛。比赛为淘汰赛制，每场比赛赢者进入下一轮。第一阶段比赛共分为上、下午场一共8场。

## **2.**   **工程项目说明**

本项目共分为两个功能，第一是面对参赛选手的报名功能，第二是面向赛事承办与组织方的管理功能。具体将在后续进行进一步阐述。

首先运行项目时，会出现Welcome窗体。



点击“开始”菜单的“赛事介绍”，出现Introduction窗体，阅读有关赛事的信息，按“返回”按钮，返回初始窗体。

点击“登录/注册”按钮，出现InputBox，会询问您的身份，选择非赛事组织方的，进入选手的登录、报名功能；选择赛事组织方的，进入管理员登陆界面。

### (一) 参赛选手身份

出现SignInForST窗体，要求输入姓名、学工号、密码进行登录。

输入的相关信息分别和Welcome窗体的Names、number、Passwords数组分别进行比对，若系统中出现相匹配的信息，弹出“登录成功”，否则提示需要进行注册。

点击“注册”按钮，进入RegisterForST窗体。


点击“返回”，返回主页面。



在RegisterForST窗体输入姓名、学工号、密码信息，点击“注册”按钮，则信息加入到Names、number、Passwords数组中，以便登录时进行比对。

出现SignInForST窗体（登录），关闭本窗体。

此时再次进行登录。

登陆成功后，登录窗体隐藏，初始窗体显示。

右上角显示个人信息。


此时点击“报名”按钮，出现EnterForGame（报名）窗体。



   先选择组别。若组别选择教职工，则出现有关年龄的文本框需要进行填写。按下“确定”按钮，则按照组别，将登录时的姓名（若是教职工组还有本窗体填写的年龄）加入到初始窗体中创建的StudentNames数组中（或者是TeacherNames与Teacherages数组中）。

   显示“报名成功”。

   按“退出”按钮，退出整个程序。

### (二) 赛事组织方身份

若是在最开始的点击“登录/注册”按钮，出现InputBox时选择赛事组织方，则出现SignInForOrganizer窗体。

只有输入正确的用户名和密码（用户名Admin，密码12345678）时，点击“登录”按钮，才会继续程序的下一个部分。

点击“返回”按钮，返回初始窗体。

登录成功后的下一个窗体为Timeset（设定比赛时间）。

默认的比赛年份为2022年，若设定时间早于程序运行时的日期，则弹出错误提示，重新进行设置。点击“确定”按钮，计算并显示程序运行当天距离设定的比赛日期还有多少天。

点击“重置”按钮，初始化当前界面，全部重新设置。

点击人员录入，进入STinformation窗体。

选择“学生”，则出现上方第一张图片的内容。

学生的信息均保存在StudentNamesATgame数组中，显示于右边的ListBox内。（初始已经录入6个学生的信息

Public StudentNamesATgame() As String = {"Egan", "Trevor", "Kerry", "Elga", "Alina", "Eddie", "", ""} ）

   分别点击“查询”“增加”“删除”“选中删除”按钮进行人员的查询与增删改。

选择“教职工”，则出现上方第二张图片的内容。

教职工的信息均保存在TeacherNamesATgame和TeacherAgesATgame数组中，显示于右边的文本框内。（初始已经录入12个教职工的信息

Public TeacherNamesATgame() As String = {"Merlin", "Edan", "Willette", "Effie", "Pansy", "Myrtle", "Sherard", "Spencer", "Dorian", "Brittany", "Sarah", "Egil", "", "", "", ""}

Public TeacherAgesATgame() As Integer = {43, 36, 54, 61, 35, 67, 64, 36, 45, 41, 63, 46, 0, 0, 0, 0}）

分别点击“按年龄查询”按钮与“按姓名查询”按钮，右边文本框内出现与左边文本框内匹配的内容。

点击“增加”按钮与“删除”按钮进行人员的增加与删除。（一次只能输一个名字）

点击“输入年龄”按钮，出现InputBox提示输入年龄，此时可输入多个，中间用“,”隔开，程序自动匹配到最后一人的年龄，多输入的年龄数据丢弃。

点击“排序”按钮，教职工组按照年龄从小到大排序。

全部人员录入完毕后，点击“确定”按钮，进入Arrangement窗体。

窗体出现时会显示学生组和教职工组的相关信息（其中如果教职工组在前一个窗体中没有排序，则先进行排序）。

点击“抽签规则”可以了解阅读抽签规则。

点击“展开”按钮，窗体展开。

展开窗体后，点击“自动抽签”按钮，进行人员分配。其中学生组随机分配，教职工组年龄最大的与年龄最小的一组，年龄次大的与年龄次小的一组，以此类推。

点击“查看”按钮，进入Check窗体。

分别选择“上午”“下午”（可多选）与比赛场地“一号场地”“二号场地”“三号场地”“四号场地”，查看人员情况。

点击“信息发布”，弹出“发布成功”。

点击“返回首页”，出现初始窗体。
