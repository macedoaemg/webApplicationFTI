using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApplicationFTI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet("soma/{valor1}/{valor2}")]
        public IActionResult Getsomar(string valor1, string valor2)
        {
            if (IsNumeric(valor1) && IsNumeric(valor2))
            {
                var soma = ConvertToDecimal(valor1) + ConvertToDecimal(valor2);
                return Ok(soma.ToString());                
            }

            return BadRequest("Valor inválido");
        }

        [HttpGet("menos/{valor1}/{valor2}")]
        public IActionResult Getdiminuir(string valor1, string valor2)
        {
            if (IsNumeric(valor1) && IsNumeric(valor2))
            {
                var soma = ConvertToDecimal(valor1) - ConvertToDecimal(valor2);
                return Ok(soma.ToString());
            }

            return BadRequest("Valor inválido");
        }

        [HttpGet("media/{valor1}/{valor2}")]
        public IActionResult Getmedia(string valor1, string valor2)
        {
            if (IsNumeric(valor1) && IsNumeric(valor2))
            {
                var soma = (ConvertToDecimal(valor1) + ConvertToDecimal(valor2)) / 2;
                return Ok(soma.ToString());
            }

            return BadRequest("Valor inválido");
        }

        [HttpGet("multi/{valor1}/{valor2}")]
        public IActionResult Getmult(string valor1, string valor2)
        {
            if (IsNumeric(valor1) && IsNumeric(valor2))
            {
                var soma = ConvertToDecimal(valor1) * ConvertToDecimal(valor2);
                return Ok(soma.ToString());
            }

            return BadRequest("Valor inválido");
        }

        [HttpGet("div/{valor1}/{valor2}")]
        public IActionResult Getdiv(string valor1, string valor2)
        {
            if (IsNumeric(valor1) && IsNumeric(valor2))
            {
                var soma = ConvertToDecimal(valor1) / ConvertToDecimal(valor2);
                return Ok(soma.ToString());
            }

            return BadRequest("Valor inválido");
        }

        private decimal ConvertToDecimal(string valor1)
        {
            decimal decimalValue;

            if (decimal.TryParse(valor1, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string valor1)
        {
            double number;
            bool isNumber = double.TryParse(
                valor1,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);

            return isNumber;
        }
    }
}
