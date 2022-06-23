# ddddocrsharp
ddddocr  c# 版本 

2022年6月23日修改.net为.net6.0版本

基于 ~~.netcore5.0~~(.net6.0)

基于sml2h3开源的ddddocr构建的c#开源项目。源项目只提供pypi版本，不能满足c#开发者的需求，特此尝试开发本项目。

项目使用了微软的Microsoft.ML.OnnxRuntime进行推理，同时依赖了OpenCvSharp4。.net6使用aot静态编译的win-x86目标程序大小仅为160m(包含84m的模型文件)

目前支持了目标检测和文字识别，暂时不支持自定义模型等。

声明:
模型版权归原作者sml2h3所有，仅供学习交流使用，如有问题欢迎提issue。

