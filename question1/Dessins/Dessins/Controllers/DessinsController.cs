using Dessins.Events;
using Microsoft.AspNetCore.Mvc;

namespace Dessins.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DessinsController : ControllerBase
    {
        [HttpGet]
        // Rien à modifier ici, juste un exemple de dessin très simple
        public ActionResult GetDrawing1()
        {
            var drawSquare = new DrawSquare(2, 2);
            
            return Ok(drawSquare);
        }

        public ActionResult GetDrawing2()
        {
            var events = new List<DrawingEvent>
            {
                new ChangeColor("blue"),
                new DrawCircle(1, 1),
                new Wait(3),
                new ChangeColor("red"),
                new DrawSquare(0, 2), new DrawSquare(2, 2),
                new Wait(1),
                new ChangeColor("yellow"),
                new DrawStar(1, 3, 20)
            };
            return Ok(events);
        }

        // TODO: Il faut ajouter une nouvelle action pour dessiner la séquence mentionnée dans l'énoncé
    }
}
