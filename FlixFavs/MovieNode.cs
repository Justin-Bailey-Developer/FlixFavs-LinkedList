using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixFavs
{

    public class Node
    {
        /*internal Movie Data { get; set; }
        internal MovieNode Next { get; set; }*/

        public Movie Data { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(Movie data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }

        public Node(Movie data, Node next)
        {
            Data = data;
            Next = next;
            Previous = null;
        }

        public Node(Movie data, Node next, Node previous)
        {
            Data = data;
            Next = next;
            Previous = previous;
        }

    }


    /*public class MovieNode
    {
        *//*internal Movie Data { get; set; }
        internal MovieNode Next { get; set; }*//*

        public Movie Data { get; set; }
        public MovieNode Next { get; set; }

        public MovieNode(Movie data)
        {
            Data = data;
        } 

        public MovieNode(Movie data, MovieNode next)
        {
            Data = data;
            Next = next;
        }

    }*/

}
