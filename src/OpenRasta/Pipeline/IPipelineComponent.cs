﻿using System.Threading.Tasks;
using OpenRasta.Web;

namespace OpenRasta.Pipeline
{
  public interface IPipelineComponent
  {
    Task Invoke(ICommunicationContext env);
  }
}