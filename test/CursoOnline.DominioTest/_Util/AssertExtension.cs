using System;
using Xunit;

namespace CursoOnline.DominioTest._Util
{
    public static class AssertExtension
    {
        public static void ComMensagem(this ArgumentException execption, string mensagem)
        {
            if(execption.Message == mensagem)
            {
                Assert.True(true);
            }
            else
            {
                Assert.False(true, $"Esperava a mensagem '{mensagem}'");
            }
        }
    }
}
