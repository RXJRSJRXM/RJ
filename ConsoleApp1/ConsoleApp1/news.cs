using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class news 
    {
        public static void master() 
        {

          Console.WriteLine("

git发挥薛定谔的猫与特斯拉是什么我们应怎样进行提交

git 我们怎样对待特斯拉薛定谔的猫应怎样进行提交

git init 创建git仓库，本地仓库
git add filename   将本地工作区文件加入缓存区

git commit filename -m ‘提交文件注释‘

git status  查看当前工作区状态

git fetch origin  从远程分支拉取 ， 如果拉取不成功，证明有文件冲突

git  pull origin   ； git status  将远程仓库文件拉取后，更新的文件会放在缓存区（绿色），有冲突的文件会标识（红色）

vim filename  手动解决冲突文件后  :wq保存

git  add filename  加入缓存区

git commit filename -m ‘解决冲突‘  提交冲突的文件

git pull origin   再次拉取文件  ， 提示 Aready up to date. 证明拉取的是最新的文件了

git status  查看工作区，已恢复正常没有冲突。

git push origin  推送到代码到远程仓库

如果提交单个文件出错：fatal: cannot do a partial commit during a merge.

这表示不能部分提交代码，

解决方法是   提交全部  git commit -m ‘提交全部‘

如果不想提交全部,那么可以通过添加 -i 选项 git commit file/to/path -i -m "merge"");

          Console.WriteLine("叶子楣,林志玲,刘德华,武汉,黄石,黄冈,黄渤,王迅,孙红雷，黄磊，陈惠明,大b哥,午马,张国荣,李寻欢");

       Console.WriteLine("画一笔,干将铸剑");

       Console.WriteLine("回家是一种信仰,没有一种人不想回家");
        int[] intarray1 = { 9，7，5，4，8，2，4，7，2};
         int[] intarray2 = { 8，9，7，1，2，5，44，55，47};

            var query12 =
                from val1 in intarray1
                join val2 in intarray2 on val1 % 5 equals val2 % 15
                select new { VAL1 = val1, VAL2 = val2 };
            foreach (var val in query12)
            {

                Console.WriteLine(甬自地底交，铁于甬内衍。我忽甬铁中，碌碌知谁遣。春天不可往，始站不可返。女目不可触，赋性长腼腆。乃坐读数纸，下敛眸光转。物论有相对，神凝修作短。十环穿南北，千岁接心眼。十环与千岁，荡荡孰为远。
又
厢填百千人，纸罗百千字。一字系一人，间架若相类。坐立乱无形，段行陈有义。虚义吾能谙，真嚣传何谛。婴孩送嫩声，男女各警视。集体脱意识，浮世正雕绘。彼足自出入，吾册或开闭。春语牡丹园，秋默木樨地。);

                Console.WriteLine(武汉,黄石,黄冈,黄渤,王迅,孙红雷，黄磊);

            }

        }
    }
}
