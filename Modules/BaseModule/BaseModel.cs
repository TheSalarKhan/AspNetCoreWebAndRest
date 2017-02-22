using System;

namespace Application.Models {

    /**
        This model houses all the attributes that a basic database entity must have, like
        Id, date of craetion etc. It also defined functions Created() and Updated() we call
        these whenever the objects are created of updated with respect to their database life cycle.
    */
    public class BaseModel {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public bool IsActive { get; set; }

        /**
            Default constructor, this is used by Entity Framework for instantiating objects.
         */
        public BaseModel() {

        }

        /**
            Overloaded constructor, we must call this constructor whenever we are creating objects
            to insert into the database. This constructor, sets the creation date time attributes.
         */
        public BaseModel(ApplicationDbContext context) {
            this.Created();
            this.Updated();
        }


        public void Created() {
            this.CreatedAt = DateTime.Now;
            this.IsActive = true;
        }

        public void Updated() {
            this.UpdatedAt = DateTime.Now;
        }

        public void Delete() {
            this.IsActive = false;
            this.Updated();
        }

        public void setActive(bool val) {
            this.IsActive = val;
            this.Updated();
        }
    }
}