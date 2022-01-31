using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MusicOnline.DAL.Model
{
    public partial class Music_OnlineContext : DbContext
    {
        public Music_OnlineContext()
        {
        }

        public Music_OnlineContext(DbContextOptions<Music_OnlineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<AlbumArtist> AlbumArtists { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Kind> Kinds { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<PlaylistSong> PlaylistSongs { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<SongSinger> SongSingers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-DT03IGN;Initial Catalog=Music_Online;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Album>(entity =>
            {
                entity.ToTable("Album");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .HasColumnName("picture")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AlbumArtist>(entity =>
            {
                entity.HasKey(e => new { e.AlbumId, e.ArtistId })
                    .HasName("PK__Album_Ar__B62CD9B2BEC353EE");

                entity.ToTable("Album_Artist");

                entity.Property(e => e.AlbumId).HasColumnName("album_id");

                entity.Property(e => e.ArtistId).HasColumnName("artist_id");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.AlbumArtists)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Album_Artist_Album");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.AlbumArtists)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Album_Artist_Artist");
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("Artist");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Profile)
                    .HasColumnType("text")
                    .HasColumnName("profile");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("Genre");

                entity.HasIndex(e => e.Id, "IX_Genre")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "NonClusteredIndex-20211207-224710")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Kind>(entity =>
            {
                entity.ToTable("Kind");

                entity.HasIndex(e => e.Id, "IX_Kind")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "NonClusteredIndex-20211207-224710")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Playlist>(entity =>
            {
                entity.ToTable("Playlist");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Playlists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Playlist_User");
            });

            modelBuilder.Entity<PlaylistSong>(entity =>
            {
                entity.HasKey(e => new { e.SongId, e.PlaylistId })
                    .HasName("PK__Playlist__BA8C6F5D20D1AAFC");

                entity.ToTable("Playlist_Song");

                entity.Property(e => e.SongId).HasColumnName("song_id");

                entity.Property(e => e.PlaylistId).HasColumnName("playlist_id");

                entity.HasOne(d => d.Playlist)
                    .WithMany(p => p.PlaylistSongs)
                    .HasForeignKey(d => d.PlaylistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Playlist_Song_Playlist");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.PlaylistSongs)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Playlist_Song_Song");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.ToTable("Song");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AlbumId).HasColumnName("album_id");

                entity.Property(e => e.Composed).HasColumnName("composed");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("country")
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.Property(e => e.KindId).HasColumnName("kind_id");

                entity.Property(e => e.Likes).HasColumnName("likes");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("link")
                    .IsFixedLength(true);

                entity.Property(e => e.Listens).HasColumnName("listens");

                entity.Property(e => e.Lyric)
                    .HasColumnType("text")
                    .HasColumnName("lyric");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Song_Album");

                entity.HasOne(d => d.ComposedNavigation)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.Composed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Song_Artist");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Song_Genre");

                entity.HasOne(d => d.Kind)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.KindId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Song_Kind");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Song_User");
            });

            modelBuilder.Entity<SongSinger>(entity =>
            {
                entity.HasKey(e => new { e.SongId, e.SingerId })
                    .HasName("PK__Song_Sin__EE0866A37A9B58DE");

                entity.ToTable("Song_Singer");

                entity.Property(e => e.SongId).HasColumnName("song_id");

                entity.Property(e => e.SingerId).HasColumnName("singer_id");

                entity.HasOne(d => d.Singer)
                    .WithMany(p => p.SongSingers)
                    .HasForeignKey(d => d.SingerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Song_Singer_Singer");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.SongSingers)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Song_Singer_Song");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("full_name")
                    .IsFixedLength(true);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("gender")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("phone")
                    .IsFixedLength(true);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("role")
                    .IsFixedLength(true);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_name")
                    .IsFixedLength(true);

                entity.Property(e => e.YearOfBirth).HasColumnName("year_of_birth");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
