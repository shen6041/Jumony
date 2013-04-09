﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ivony.Html.Web
{

  /// <summary>
  /// 定义处理器包装，实现此接口声明自己是一个处理器的包装，不在该实例上查找各种处理方法。
  /// </summary>
  public interface IHandlerWrapper
  {

    /// <summary>
    /// 获取被包装的处理器
    /// </summary>
    public object Handler { get; }

  }
}