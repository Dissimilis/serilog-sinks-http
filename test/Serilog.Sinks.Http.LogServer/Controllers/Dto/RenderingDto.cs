﻿namespace Serilog.Sinks.Http.LogServer.Controllers.Dto
{
    public class RenderingDto
    {
        public string Format { get; set; }

        public string Rendering { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as RenderingDto;

            if (other == null)
                return false;

            return
                Format == other.Format &&
                Rendering == other.Rendering;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
