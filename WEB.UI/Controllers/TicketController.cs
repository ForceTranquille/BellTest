using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WEB.UI.Models;

namespace WEB.UI.Controllers
{
    public class TicketController : Controller
    {
        private HelpDeskEntities contextEF = new HelpDeskEntities();

        public ActionResult Liste()
        {
            List<Ticket> tickets = contextEF.Ticket.ToList();
            return View(tickets);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                Ticket ticket = contextEF.Ticket.Single(t => t.TICKETNO == id);
                //mapper instance de la base vers modele editee
                TicketEditee ticketEditee = AutoMapper.Mapper.Map<TicketEditee>(ticket);
                return View(ticketEditee);
            }
            else
            {
                // pas id creation
                return View(new TicketEditee());
            }

        }

        [HttpPost]
        public ActionResult Edit(TicketEditee ticket)
        {
            if (!ModelState.IsValid)
            {
                return View(ticket);
            }

            if (ticket.TICKETNO.HasValue)
            {
                //mapper   
                Ticket ticketDB = contextEF.Ticket.Single(t => t.TICKETNO == ticket.TICKETNO);
                //propager
                ticketDB = AutoMapper.Mapper.Map<TicketEditee, Ticket>(ticket, ticketDB);
            }
            else
            {
                //creation
                var nouveauTicket = AutoMapper.Mapper.Map<Ticket>(ticket);
                int idMax = contextEF.Ticket.Max(t => t.TICKETNO);
                nouveauTicket.TICKETNO = idMax + 1;

                contextEF.Ticket.Add(nouveauTicket);

            }

            //pousser
            contextEF.SaveChanges();

            return RedirectToAction("Liste");
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            Ticket ticket = contextEF.Ticket.Single(t => t.TICKETNO == id);
            contextEF.Ticket.Remove(ticket);
            contextEF.SaveChanges();
            return Json(new { Suppression = "OK" });
        }
       



    }
}