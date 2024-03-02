using Solutions.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solutions.Test.Medium
{
    public class DeepestLeavesSumSolutionTests
    {
        [Fact]
        public void LevelTree1()
        {
          
            var node=TreeNodeBuilder.Instance()
                                    .WithValue(1)
                                    .WithLeft(a=>
                                                a.WithValue(2)
                                                            .WithLeft(b=>b.WithValue(4)
                                                                                        .WithLeft(c=>c.WithValue(7))
                                                            )
                                                            .WithRight(b=>b.WithValue(5)
                                                                                        
                                                            )
                                            )
                                    .WithRight(a=>
                                                a.WithValue(3)
                                                            .WithRight(b=>
                                                                        b.WithValue(6)
                                                                                    .WithRight(c=>c.WithValue(8))
                                                            )
                            
                                    )
                                    .Build();


            var sum = node.GetSumDeepestValue(0);
            Assert.Equal( 15, sum.Value );


        }

        [Fact]
        public void LevelTree2()
        {

            var node = TreeNodeBuilder.Instance()
                                    .WithValue(1)
                                    //.WithLeft(a =>
                                    //            a.WithValue(2)
                                    //                        .WithLeft(b => b.WithValue(4)
                                    //                                                    .WithLeft(c => c.WithValue(7))
                                    //                        )
                                    //                        .WithRight(b => b.WithValue(5)

                                    //                        )
                                    //        )
                                    //.WithRight(a =>
                                    //            a.WithValue(3)
                                    //                        .WithRight(b =>
                                    //                                    b.WithValue(6)
                                    //                                                .WithRight(c => c.WithValue(8))
                                    //                        )

                                    //)
                                    .Build();


            var sum = node.GetSumDeepestValue(0);
            Assert.Equal(1, sum.Value);


        }


        [Fact]
        public void LevelTree3()
        {

            var node = TreeNodeBuilder.Instance()
                                    .WithValue(6)
                                    .WithLeft(a =>
                                                a.WithValue(7)
                                                            .WithLeft(b => b.WithValue(2)
                                                                                        .WithLeft(c => c.WithValue(9))
                                                            )
                                                            .WithRight(b => b.WithValue(7)
                                                                                         .WithLeft(c => c.WithValue(1))
                                                                                         .WithRight(c => c.WithValue(4))


                                                            )
                                            )
                                    .WithRight(a =>
                                                a.WithValue(8)
                                                            .WithLeft(b=>b.WithValue(1))
                                                            .WithRight(b =>
                                                                        b.WithValue(3)
                                                                                    .WithRight(c => c.WithValue(5))
                                                            )
                                                           

                                    )
                                    .Build();


            var sum = node.GetSumDeepestValue(0);
            Assert.Equal(19, sum.Value);


        }


    }
    public class TreeNodeBuilder 
    {
        public static TreeNodeBuilder Instance()
        { 
            return new TreeNodeBuilder();
        }
        private int value;
        private TreeNodeBuilder leftBuilder;
        private TreeNodeBuilder rightBuilder;

        public TreeNodeBuilder()
        {
            value = 0;
            leftBuilder = null;
            rightBuilder = null;
        }

        public TreeNodeBuilder WithLeft(Action<TreeNodeBuilder> nodeBuilder) 
        {
            var builder = new TreeNodeBuilder();
            nodeBuilder.Invoke(builder);
            this.leftBuilder = builder;
            return this;
        }

        public TreeNodeBuilder WithRight(Action<TreeNodeBuilder> nodeBuilder)
        {
            var builder = new TreeNodeBuilder();
            nodeBuilder.Invoke(builder);
            this.rightBuilder = builder;
            return this;
        }
        public TreeNodeBuilder WithValue(int value)
        {
            this.value = value;
            return this;
        }
        public TreeNode Build()
        {
           
            return new TreeNode(value,leftBuilder?.Build(),rightBuilder?.Build());

        }

    }
}
